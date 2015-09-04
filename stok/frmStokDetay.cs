using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje_BilisimERP.stok
{
  public partial class frmStokDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmStokDetay(string stokID)
    {
      InitializeComponent();
      _stokID = stokID;
    }
    string _stokID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    void AktifTextBox(object sender, EventArgs e)
    {
      DevExpress.XtraEditors.TextEdit aktifText = (TextEdit)sender;
      aktifText.BackColor = Color.AntiqueWhite;
    }
    void PasifTextBox(object sender, EventArgs e)
    {
      DevExpress.XtraEditors.TextEdit pasifText = (TextEdit)sender;
      pasifText.BackColor = Color.White;
    }
    private void frmStokDetay_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        if (_stokID != "-1")
        {
          using (SqlCommand cmd = new SqlCommand(@"SELECT        StokID, StokKodu, StokTanim, StokMiktar, StokMinMiktar, StokResim, KaydedenKullaniciID, KayitTarihi, GuncelleyenKullaniciID, GuncellemeTarihi FROM dbo.Stok WHERE (StokID = @StokID)", baglanti))
          {
            cmd.Parameters.Add("StokID", SqlDbType.Int).Value = _stokID;
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
              if (dr.Read())
              {
                txtStokKodu.Text = dr["StokKodu"].ToString();
                txtStokTanim.Text = dr["StokTanim"].ToString();
                txtStokMiktar.Text = dr["StokMiktar"].ToString();
                txtStokMinMiktar.Text = dr["StokMinMiktar"].ToString();

                //Kaydedilen resim varsa, Db den pictureEdit e taşınıyor.
                if (dr["StokResim"].ToString() != "")
                {
                  System.Drawing.Image resim;
                  using (System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])dr["StokResim"]))
                  {
                    resim = System.Drawing.Image.FromStream(ms);
                    peStokResim.Image = resim;
                  }
                }
              }
            }
          }
        }
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show("Hata Kodu : " + hata.Message);
      }
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {

        decimal StokMiktar = 0, StokMinMiktar = 0;
        #region Boş alan Kontrolü
        if (txtStokKodu.Text == "")
        {
          txtStokKodu.Focus();
          XtraMessageBox.Show("Zorunlu alanlar boş geçilemez.");
          return;
        }
        if (txtStokTanim.Text == "")
        {
          txtStokTanim.Focus();
          XtraMessageBox.Show("Zorunlu alanlar boş geçilemez.");
          return;
        }
        if (decimal.TryParse(txtStokMiktar.Text, out StokMiktar) == false)
        {
          txtStokMiktar.Focus();
          XtraMessageBox.Show("eksik yada hatalı değer girdiniz.");
          return;
        }
        if (decimal.TryParse(txtStokMinMiktar.Text, out StokMinMiktar) == false)
        {
          txtStokMinMiktar.Focus();
          XtraMessageBox.Show("eksik yada hatalı değer girdiniz.");
          return;
        }
        #endregion

        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;

        byte[] buffer = null;

        if (peStokResim.Image != null)
        {
          //pe deki resmi RAM deki buffer bloğuna attık.
          Image image1 = peStokResim.Image;
          System.IO.MemoryStream ms = new System.IO.MemoryStream();
          image1.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

          buffer = ms.ToArray();

          ms.Close();
          ms.Dispose();
        }


        if (_stokID == "-1")
        {
          cmd.CommandText = "Insert Into Stok(StokKodu, StokTanim, StokMiktar, StokMinMiktar, StokResim, KaydedenKullaniciID, KayitTarihi) VAlues( @StokKodu, @StokTanim, @StokMiktar, @StokMinMiktar, @StokResim, @KaydedenKullaniciID, @KayitTarihi)";
          cmd.Parameters.Add("@KaydedenKullaniciID", SqlDbType.Int).Value= cs.csKullanici.kullaniciID;
          cmd.Parameters.Add("@KayitTarihi", SqlDbType.DateTime).Value = DateTime.Now;
        }
        else
        {
          cmd.CommandText = "Update Stok SET  StokKodu=@StokKodu, StokTanim=@StokTanim, StokMiktar=@StokMiktar, StokMinMiktar=@StokMinMiktar, StokResim=@StokResim, GuncelleyenKullaniciID=@GuncelleyenKullaniciID, GuncellemeTarihi=@GuncellemeTarihi Where StokID=@StokID";
          cmd.Parameters.Add("@StokID", SqlDbType.Int).Value= _stokID;
          cmd.Parameters.Add("@GuncelleyenKullaniciID", SqlDbType.Int).Value = cs.csKullanici.kullaniciID;
          cmd.Parameters.Add("@GuncellemeTarihi", SqlDbType.DateTime).Value = DateTime.Now;
        }

        cmd.Parameters.Add("@StokKodu", SqlDbType.VarChar).Value = txtStokKodu.Text;
        cmd.Parameters.Add("@Stoktanim", SqlDbType.VarChar).Value = txtStokTanim.Text;
        cmd.Parameters.Add("@StokMiktar", SqlDbType.Decimal).Value = StokMiktar;
        cmd.Parameters.Add("@StokMinMiktar", SqlDbType.Decimal).Value = StokMinMiktar;

        if (buffer == null)
          cmd.Parameters.Add("@StokResim", SqlDbType.Image).Value = DBNull.Value;
        else
          cmd.Parameters.Add("@StokResim", SqlDbType.Image).Value = buffer;

        cmd.ExecuteNonQuery();

        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show("Hata Kodu : " + hata.Message);
      }
    }
  }
}