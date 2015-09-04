using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje_BilisimERP
{
  public partial class frmAnaForm : Form
  {
    public frmAnaForm()
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
    private void btnCikis_Click(object sender, EventArgs e)
    {
      //Application.OpenForms -> uygulamadaki açık olan formların name lerini tutar.
      // (frmKullaniciGiris)Application.OpenForms["frmKullaniciGiris"] -> açık olan o forma konumlan ve public olan alt fonksiyonlarını getir.

      ((frmKullaniciGiris)Application.OpenForms["frmKullaniciGiris"]).ProgramiKapat();
    }

    private void btnKullaniciListe_Click(object sender, EventArgs e)
    {
      kullanici.frmKullaniciListe frmKullaniciListe = new kullanici.frmKullaniciListe();
      FormuAc(frmKullaniciListe);
    }

    private void btnDepartmanListe_Click(object sender, EventArgs e)
    {
      //frmDepartmanListe frmDepartmanListe = new frmDepartmanListe();
      //FormuAc(frmDepartmanListe);
    }

		private void nerdeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Test");
		}
  }
}
