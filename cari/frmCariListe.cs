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

namespace Proje_BilisimERP.cari
{
  public partial class frmCariListe : DevExpress.XtraEditors.XtraForm
  {
    public frmCariListe()
    {
      InitializeComponent();
    }

    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void frmCariListe_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        using (da.SelectCommand = new SqlCommand(@"SELECT        dbo.Cari.CariID, dbo.Cari.CariKodu, dbo.Cari.CariTanim, dbo.Cari.CariGrupID, dbo.CariGrup.CariGrupTanim
FROM            dbo.Cari INNER JOIN
                         dbo.CariGrup ON dbo.Cari.CariGrupID = dbo.CariGrup.CariGrupID", baglanti))
        {
          da.Fill(dt);
          gcListe.DataSource = dt;
        }
        //gvListe.BestFitColumns();

        new cs.csGridLayout(cs.csGridLayout.enGridArayuzIslemleri.Get, this, Convert.ToInt32(cs.csKullanici.kullaniciID), baglanti);


      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      cari.frmCariDetay frmCariDetay = new frmCariDetay("-1");
      if (frmCariDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      try
      {
        if (gvListe.FocusedRowHandle < 0)
        {
          XtraMessageBox.Show("Seçili satır yok");
          return;
        }

        if (XtraMessageBox.Show("Seçilen Satırı Silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;


        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        using (SqlCommand cmd = new SqlCommand("Delete From Cari Where CariID=@CariID", baglanti))
        {
          cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellDisplayText("CariID");

          cmd.ExecuteNonQuery();
        }

        XtraMessageBox.Show("Silme işlemi başarılı");
        //grid yenileniyor.
        dt.Clear();
        da.Fill(dt);
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {
      cari.frmCariDetay frmCariDetay = new cari.frmCariDetay(gvListe.GetFocusedRowCellDisplayText("CariID"));
      if (frmCariDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }

    private void btnExcel_Click(object sender, EventArgs e)
    {
      try
      {
        frmExceleAktar frmExceleAktar = new frmExceleAktar(gcListe);
        frmExceleAktar.Show();
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnEkranGorunumKaydet_Click(object sender, EventArgs e)
    {
      if (baglanti.State == ConnectionState.Closed) baglanti.Open();
      new cs.csGridLayout(cs.csGridLayout.enGridArayuzIslemleri.Set, this, Convert.ToInt32(cs.csKullanici.kullaniciID), baglanti);
    }

    private void btnEkranGorunumSifirla_Click(object sender, EventArgs e)
    {
      if (baglanti.State == ConnectionState.Closed) baglanti.Open();
      cs.csGridLayout.LayoutClear(Convert.ToInt32(cs.csKullanici.kullaniciID), this.Name, gvListe.Name, baglanti);
    }
  }
}