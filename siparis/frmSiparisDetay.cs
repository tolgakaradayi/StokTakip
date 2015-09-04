using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje_BilisimERP.siparis
{
	public partial class frmSiparisDetay : DevExpress.XtraEditors.XtraForm
	{
		public frmSiparisDetay(string siparisID)
		{
			InitializeComponent();
			_siparisID = siparisID;
		}
		string _siparisID = "-1";
		public string cariID = "-1";
		SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		//sql connection un yaptığı bütün DML komutlarını takip eder ve bir hata olursa geriye dönük olarak yapılan bütün işlemleri ilk haline geri çeker (ÖNEMLİ.. ID leri geri vermez.)
		SqlTransaction tr;

		public string stokID = "-1", stokTanim = "";
		private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			if (e.Button.Index == 0)
			{
				//ilk butona basıldıysa
				cari.frmCariListeSecim frmCariListeSecim = new cari.frmCariListeSecim();
				frmCariListeSecim.ShowDialog();
			}
			else if (e.Button.Index == 1)
			{
				cariID = "-1";
				txtCariKodu.Text = "";
				txtCariTanim.Text = "";
				txtCariGrupTanim.Text = "";
			}
		}

		private void frmSiparisDetay_Load(object sender, EventArgs e)
		{
			try
			{
				if (baglanti.State == ConnectionState.Closed) baglanti.Open();

				#region lkpStok dolduruluyor
				using (SqlDataAdapter daStok = new SqlDataAdapter("Select StokID, StokKodu, StokTanim From Stok", baglanti))
				{
					DataTable dtStok = new DataTable();
					daStok.Fill(dtStok);

					lkpStok.DataSource = dtStok;
					lkpStok.PopulateColumns();
					lkpStok.DisplayMember = "StokTanim";
					lkpStok.ValueMember = "StokID";
					lkpStok.Columns["StokID"].Visible = false;
					lkpStok.Columns["StokTanim"].Caption = "Stok Tanım";
					lkpStok.Columns["StokKodu"].Caption = "Stok Kodu";
				}
				#endregion

				using (da.SelectCommand = new SqlCommand(@"SELECT dbo.SiparisDetay.SiparisDetayID, dbo.SiparisDetay.SiparisID, dbo.SiparisDetay.StokID, dbo.SiparisDetay.SiparisMiktar, dbo.SiparisDetay.BirimFiyat, 
                         dbo.SiparisDetay.SatirToplam, dbo.Stok.StokKodu, '' as StokID2
FROM            dbo.SiparisDetay INNER JOIN
                         dbo.Stok ON dbo.SiparisDetay.StokID = dbo.Stok.StokID
WHERE        (dbo.SiparisDetay.SiparisID = @SiparisID)", baglanti))
				{
					da.SelectCommand.Parameters.Add("@SiparisID", SqlDbType.Int).Value = _siparisID;
					da.Fill(dt);
					gcListe.DataSource = dt;
				}

				if (_siparisID == "-1")
				{
					//boş satır eklem işlemini yaptık
					DataRow yeniSatir = dt.NewRow();
					dt.Rows.Add(yeniSatir);
				}
				else
				{
					//form güncelleme ile açılmışsa
					using (SqlCommand cmd = new SqlCommand(@"SELECT        dbo.Siparis.KullaniciID, dbo.Siparis.SiparisNo, dbo.Siparis.CariID, dbo.Siparis.SiparisTarihi, dbo.Siparis.Durum, dbo.Cari.CariKodu, dbo.Cari.CariTanim, 
                         dbo.CariGrup.CariGrupTanim
FROM            dbo.Siparis INNER JOIN
                         dbo.Cari ON dbo.Siparis.CariID = dbo.Cari.CariID LEFT OUTER JOIN
                         dbo.CariGrup ON dbo.Cari.CariGrupID = dbo.CariGrup.CariGrupID
WHERE        (dbo.Siparis.SiparisID = @SiparisID) ", baglanti))
					{
						cmd.Parameters.Add("@SiparisID", SqlDbType.Int).Value = _siparisID;
						using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
						{
							if (dr.Read())
							{
								txtSiparisNo.Text = dr["SiparisNo"].ToString();
								deSiparisTarihi.DateTime = (DateTime)dr["SiparisTarihi"];
								txtCariKodu.Text = dr["CariKodu"].ToString();
								txtCariTanim.Text = dr["CariTanim"].ToString();
								txtCariGrupTanim.Text = dr["CariGrupTanim"].ToString();
								cariID = dr["CariID"].ToString();
							}
						}
					}
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void cbtnYeniSatir_Click(object sender, EventArgs e)
		{
			DataRow yeniSatir = dt.NewRow();
			dt.Rows.Add(yeniSatir);
		}

		private void gvListe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			if (e.Column == gvListe.Columns["SiparisMiktar"] || e.Column == gvListe.Columns["BirimFiyat"])
			{
				decimal birimFiyat = 0, siparisMiktar = 0;
				if (decimal.TryParse(gvListe.GetRowCellValue(e.RowHandle, "SiparisMiktar").ToString(), out siparisMiktar) == false)
				{

				}
				if (decimal.TryParse(gvListe.GetRowCellValue(e.RowHandle, "BirimFiyat").ToString(), out birimFiyat) == false)
				{

				}
				dt.Rows[e.RowHandle]["SiparisMiktar"] = siparisMiktar;
				dt.Rows[e.RowHandle]["BirimFiyat"] = birimFiyat;
				dt.Rows[e.RowHandle]["SatirToplam"] = siparisMiktar * birimFiyat;
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				#region Boş Alan Kontrolü yapılıyor.
				if (txtSiparisNo.Text == "")
				{
					XtraMessageBox.Show("Zorunlu alanlar boş geçilemez");
					txtSiparisNo.Focus();
					return;
				}
				if (deSiparisTarihi.Text == "")
				{
					XtraMessageBox.Show("Zorunlu alanlar boş geçilemez");
					deSiparisTarihi.Focus();
					return;
				}
				if (cariID == "-1")
				{
					XtraMessageBox.Show("Zorunlu alanlar boş geçilemez");
					txtCariKodu.Focus();
					return;
				}
				#endregion

				if (baglanti.State == ConnectionState.Closed) baglanti.Open();

				//Bu bağlantıyı takip et.
				tr = baglanti.BeginTransaction();

				if (_siparisID == "-1")
				{
					#region Insert İşlemi
					//insert
					//SET @YeniID=SCOPE_IDENTITY() --> bizim tarafımızdan son kaydedilen satırdaki ID değerini @Yeni değişlkenine atama işlemi yapar.
					using (SqlCommand cmd = new SqlCommand(@"Insert Into Siparis Values(@KullaniciID, @SiparisNo, @CariID, @SiparisTarihi, @Durum) SET @YeniID=SCOPE_IDENTITY()", baglanti, tr))
					{
						cmd.Parameters.Add("@YeniID", SqlDbType.Int).Direction = ParameterDirection.Output;

						cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = cs.csKullanici.kullaniciID;
						cmd.Parameters.Add("@SiparisNo", SqlDbType.Int).Value = txtSiparisNo.Text;
						cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = cariID;
						cmd.Parameters.Add("@SiparisTarihi", SqlDbType.DateTime).Value = deSiparisTarihi.DateTime;
						cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = true;
						
						cmd.ExecuteNonQuery();
						//sql cümlesinin dışarı fırlattığı değeri okuyoruz.
						_siparisID = cmd.Parameters["@YeniID"].Value.ToString();
					}

					foreach (DataRow satir in dt.AsEnumerable())
					{
						//gridin satırındaki (dt ye ekli olan satırlar) bütün bilgiler, satır satır okunup her satır için ayrı ayrı insert işlemi yapılarak veritabanına ekleniyor.
						using (SqlCommand cmd = new SqlCommand(@"Insert Into SiparisDetay values(@SiparisID, @StokID, @SiparisMiktar, @BirimFiyat, @SatirToplam)", baglanti, tr))
						{
							cmd.Parameters.Add("@SiparisID", SqlDbType.Int).Value = _siparisID;
							cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = satir["StokID"].ToString();
							cmd.Parameters.Add("@SiparisMiktar", SqlDbType.Decimal).Value = satir["SiparisMiktar"].ToString();
							cmd.Parameters.Add("@BirimFiyat", SqlDbType.Decimal).Value = satir["BirimFiyat"].ToString();
							cmd.Parameters.Add("@SatirToplam", SqlDbType.Decimal).Value = satir["SatirToplam"].ToString();

							cmd.ExecuteNonQuery();
						}
					}
					#endregion
				}
				else
				{
					using (SqlCommand cmd = new SqlCommand(@"
update Siparis  SET KullaniciID=@KullaniciID, SiparisNo=@SiparisNo, CariID=@CariID, SiparisTarihi=@SiparisTarihi Where SiparisID=@SiparisID;
Delete From SiparisDetay Where SiparisID=@SiparisID", baglanti, tr))
					{
						cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = cs.csKullanici.kullaniciID;
						cmd.Parameters.Add("@SiparisNo", SqlDbType.Int).Value = txtSiparisNo.Text;
						cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = cariID;
						cmd.Parameters.Add("@SiparisTarihi", SqlDbType.DateTime).Value = deSiparisTarihi.DateTime;
						cmd.Parameters.Add("@SiparisID", SqlDbType.Int).Value = _siparisID;

						cmd.ExecuteNonQuery();
					}

					foreach (DataRow satir in dt.AsEnumerable())
					{
						//gridin satırındaki (dt ye ekli olan satırlar) bütün bilgiler, satır satır okunup her satır için ayrı ayrı insert işlemi yapılarak veritabanına ekleniyor.
						using (SqlCommand cmd = new SqlCommand(@"Insert Into SiparisDetay values(@SiparisID, @StokID, @SiparisMiktar, @BirimFiyat, @SatirToplam)", baglanti, tr))
						{
							cmd.Parameters.Add("@SiparisID", SqlDbType.Int).Value = _siparisID;
							cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = satir["StokID"].ToString();
							cmd.Parameters.Add("@SiparisMiktar", SqlDbType.Decimal).Value = satir["SiparisMiktar"].ToString();
							cmd.Parameters.Add("@BirimFiyat", SqlDbType.Decimal).Value = satir["BirimFiyat"].ToString();
							cmd.Parameters.Add("@SatirToplam", SqlDbType.Decimal).Value = satir["SatirToplam"].ToString();

							cmd.ExecuteNonQuery();
						}
					}
				}

				tr.Commit(); //herhangi bir problem yok. tr nin takip ettiği btün sql cümleciklerini mdf için uygula (DML check lerini işaretle)
				XtraMessageBox.Show("Kaydetme işlemi başarılı");
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (Exception hata)
			{
				tr.Rollback();// bir hata oldu. yapılan işlemleri geri al.
				_siparisID = "-1";
				XtraMessageBox.Show(hata.Message);
			}
		}

		private void txtStokTanim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			stok.frmStokListeSecim frmStokListeSecim = new stok.frmStokListeSecim();
			if (frmStokListeSecim.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				gvListe.SetFocusedRowCellValue(colStokID2, stokID);
			}

			foreach (DataRow item in dt.AsEnumerable())
			{
				MessageBox.Show(item["StokID2"].ToString());
			}
		}
	}
}