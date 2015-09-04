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
  public partial class frmCariListeSecim : DevExpress.XtraEditors.XtraForm
  {
    public frmCariListeSecim()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void frmCariListeSecim_Load(object sender, EventArgs e)
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
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }
    private void btnSec_Click(object sender, EventArgs e)
    {
      //grid üzerinde bir seçim yapılmamışsa, işlem yapma
      if (gvListe.FocusedRowHandle < 0) 
        return;
      ((siparis.frmSiparisDetay)Application.OpenForms["frmSiparisDetay"]).cariID = gvListe.GetFocusedRowCellDisplayText("CariID");

      ((siparis.frmSiparisDetay)Application.OpenForms["frmSiparisDetay"]).txtCariKodu.Text = gvListe.GetFocusedRowCellDisplayText("CariKodu");

      ((siparis.frmSiparisDetay)Application.OpenForms["frmSiparisDetay"]).txtCariTanim.Text = gvListe.GetFocusedRowCellDisplayText("CariTanim");

      ((siparis.frmSiparisDetay)Application.OpenForms["frmSiparisDetay"]).txtCariGrupTanim.Text = gvListe.GetFocusedRowCellDisplayText("CariGrupTanim");

      this.Close();
    }

    private void gvListe_DoubleClick(object sender, EventArgs e)
    {
      btnSec_Click(null, null);
    }
  }
}