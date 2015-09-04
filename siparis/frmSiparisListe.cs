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

namespace Proje_BilisimERP.siparis
{
  public partial class frmSiparisListe : DevExpress.XtraEditors.XtraForm
  {
    public frmSiparisListe()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void frmSiparisListe_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        using (da.SelectCommand = new SqlCommand(@"SELECT        dbo.Siparis.SiparisID, dbo.Siparis.SiparisNo, dbo.Siparis.SiparisTarihi, dbo.Siparis.Durum, dbo.Cari.CariKodu, dbo.Cari.CariTanim, 
                         dbo.CariGrup.CariGrupTanim
FROM            dbo.Siparis INNER JOIN
                         dbo.Cari ON dbo.Siparis.CariID = dbo.Cari.CariID INNER JOIN
                         dbo.CariGrup ON dbo.Cari.CariGrupID = dbo.CariGrup.CariGrupID", baglanti))
        {
          da.Fill(dt);
          gcListe.DataSource = dt;
        }
        gvListe.BestFitColumns(); // gird kolonlarının uzunlukları, hücre içindeki yazı kadar uzasın. :)
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
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

    private void btnEkle_Click(object sender, EventArgs e)
    {
      siparis.frmSiparisDetay frmSiparisDetay = new frmSiparisDetay("-1");
      if (frmSiparisDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0) return;
      siparis.frmSiparisDetay frmSiparisDetay = new frmSiparisDetay(gvListe.GetFocusedRowCellDisplayText("SiparisID"));
      if (frmSiparisDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }

    private void cbtnSatiriYazdir_Click(object sender, EventArgs e)
    {
      if (gvListe.FocusedRowHandle < 0) return;
      //XtraReport1 rpt = new XtraReport1();
      //rpt.xlblSiparisTarihi.Text = DateTime.Now.ToString();

      ReportPrintTool pt1 = new ReportPrintTool(
        InitReport(InitData(gvListe.GetFocusedRowCellDisplayText("SiparisID")))
        );
      pt1.ShowPreviewDialog();
    }

    private void cbtnRaporDizayn_Click(object sender, EventArgs e)
    {
      ReportDesignTool rd1 = new ReportDesignTool(InitReport(InitData(gvListe.GetFocusedRowCellDisplayText("SiparisID"))));
      rd1.ShowDesigner();
    }


    #region Yazdırma İşlemi
    DataTable InitData(string siparisID)
    {
      if (baglanti.State == ConnectionState.Closed) baglanti.Open();

      DataTable dt = new DataTable();
      using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT        dbo.Siparis.SiparisNo, dbo.Cari.CariTanim, dbo.CariGrup.CariGrupTanim, dbo.Siparis.SiparisTarihi, dbo.Stok.StokKodu, dbo.SiparisDetay.SiparisMiktar, 
                         dbo.SiparisDetay.BirimFiyat, dbo.SiparisDetay.SatirToplam, dbo.Stok.StokTanim
FROM            dbo.Siparis INNER JOIN
                         dbo.SiparisDetay ON dbo.Siparis.SiparisID = dbo.SiparisDetay.SiparisID INNER JOIN
                         dbo.Cari ON dbo.Siparis.CariID = dbo.Cari.CariID INNER JOIN
                         dbo.Stok ON dbo.SiparisDetay.StokID = dbo.Stok.StokID INNER JOIN
                         dbo.CariGrup ON dbo.Cari.CariGrupID = dbo.CariGrup.CariGrupID
WHERE        (dbo.Siparis.SiparisID = @SiparisID)", baglanti))
      {
        da.SelectCommand.Parameters.Add("@SiparisID", SqlDbType.Int).Value = siparisID;
        da.Fill(dt);
      }
      return dt;
    }

    XtraReport InitReport(DataTable dt)
    {
      XtraReport xr = new XtraReport();
      xr.LoadLayout(Application.StartupPath + @"\reportLayouts\siparisDetay.repx");
      BindingSource bs = new BindingSource();
      bs.DataSource = dt;
      xr.DataSource = bs;

      return xr;
    } 
    #endregion

  }
}