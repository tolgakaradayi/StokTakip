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
using DevExpress.XtraReports.UI;

namespace Proje_BilisimERP.stok
{
  public partial class frmStokListe : DevExpress.XtraEditors.XtraForm
  {
    public frmStokListe()
    {
      InitializeComponent();
    }

    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void frmStokListe_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        using (da.SelectCommand = new SqlCommand(@"SELECT        StokID, StokKodu, StokTanim, StokMiktar, StokMinMiktar, StokResim, KaydedenKullaniciID, KayitTarihi, GuncelleyenKullaniciID, GuncellemeTarihi
FROM            dbo.Stok", baglanti))
        {
          dt.Clear();
          da.Fill(dt);
          gcListe.DataSource = dt;
        }
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      stok.frmStokDetay frmStokDetay = new frmStokDetay("-1");
      if (frmStokDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0) return;

      stok.frmStokDetay frmStokDetay = new frmStokDetay(gvListe.GetFocusedRowCellDisplayText("StokID"));
      if (frmStokDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }

    private void btnRaporDizayn_Click(object sender, EventArgs e)
    {
      ReportDesignTool rd1 = new ReportDesignTool(InitReport(InitData()));
      rd1.ShowDesigner();
    }

    private void btnListeYazdir_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0) return;

      ReportPrintTool pt1 = new ReportPrintTool(
        InitReport(InitData())
        );
      pt1.ShowPreviewDialog();
    }
    #region Yazdırma İşlemi
    DataTable InitData()
    {
      if (baglanti.State == ConnectionState.Closed) baglanti.Open();

      DataTable dt = new DataTable();
      using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT        StokKodu, StokTanim, StokMiktar, StokMinMiktar, StokResim FROM            dbo.Stok", baglanti))
      {
        da.Fill(dt);
      }
      return dt;
    }

    XtraReport InitReport(DataTable dt)
    {
      XtraReport xr = new XtraReport();
      xr.LoadLayout(Application.StartupPath + @"\reportLayouts\stokListe.repx");
      BindingSource bs = new BindingSource();
      bs.DataSource = dt;
      xr.DataSource = bs;

      return xr;
    }
    #endregion
  }
}