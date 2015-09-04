using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Proje_BilisimERP
{
  public partial class frmAnaFormRibbon : DevExpress.XtraBars.Ribbon.RibbonForm
  {
    public frmAnaFormRibbon()
    {
      InitializeComponent();
    }
    void FormuAc(Form gelenForm)
    {
      bool buldum = false;
      foreach (var item in MdiChildren)
      {
        if (gelenForm.GetType() == item.GetType())
        {
          buldum = true;
          item.Activate();
          break;
        }
      }

      if (buldum == false)
      {
        gelenForm.MdiParent = this;
        gelenForm.Show();
      }
    }
    private void btnDepartmanListe_ItemClick(object sender, ItemClickEventArgs e)
    {
      Departman.frmDeparmanListe frmDeparmanListe = new Departman.frmDeparmanListe();
      FormuAc(frmDeparmanListe);
    }
    private void frmAnaFormRibbon_FormClosed(object sender, FormClosedEventArgs e)
    {
      ((frmKullaniciGiris)Application.OpenForms["frmKullaniciGiris"]).ProgramiKapat();
    }
    private void btnUnvan_ItemClick(object sender, ItemClickEventArgs e)
    {
      Unvan.frmUnvanListe frmUnvanListe = new Unvan.frmUnvanListe();
      FormuAc(frmUnvanListe);
    }
    private void btnDepartmanUnvan_ItemClick(object sender, ItemClickEventArgs e)
    {
      Departman.frmDepartmanUnvan frmDepartmanUnvan = new Departman.frmDepartmanUnvan();
      FormuAc(frmDepartmanUnvan);
    }
    private void frmAnaFormRibbon_Load(object sender, EventArgs e)
    {
      try
      {
        lblKullaniciBilgileri.Caption ="Giriş Yapan Kullanıcı : "+ cs.csKullanici.kullaniciKodu;

      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnStokListe_ItemClick(object sender, ItemClickEventArgs e)
    {
      stok.frmStokListe frmStokListe = new stok.frmStokListe();
      FormuAc(frmStokListe);
    }

    private void btnCariGrupListe_ItemClick(object sender, ItemClickEventArgs e)
    {
      cari.frmCariGrupListe frmCariGrupListe = new cari.frmCariGrupListe();
      FormuAc(frmCariGrupListe);
    }

    private void btnCariListe_ItemClick(object sender, ItemClickEventArgs e)
    {
      cari.frmCariListe frmCariListe = new cari.frmCariListe();
      FormuAc(frmCariListe);
    }

    private void btnSiparisListe_ItemClick(object sender, ItemClickEventArgs e)
    {
      siparis.frmSiparisListe frmSiparisListe = new siparis.frmSiparisListe();
      FormuAc(frmSiparisListe);
    }

    private void btnPivotRapor_ItemClick(object sender, ItemClickEventArgs e)
    {
 
    }

    private void btnPivotRapor_ItemClick_1(object sender, ItemClickEventArgs e)
    {
      frmPivotRapor frmPivotRapor = new frmPivotRapor();
      FormuAc(frmPivotRapor);
    }
  }
}