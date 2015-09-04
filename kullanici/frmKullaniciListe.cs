using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje_BilisimERP.kullanici
{
  public partial class frmKullaniciListe : Form
  {
    public frmKullaniciListe()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void frmKullaniciListe_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        using (da.SelectCommand = new SqlCommand(@"SELECT        dbo.Kullanici.KullaniciID, dbo.Kullanici.KullaniciKodu, dbo.Kullanici.KullaniciSifre, dbo.Kullanici.DepartmanID, dbo.Kullanici.Aktif, dbo.Departman.DepartmanTanim
FROM            dbo.Kullanici LEFT OUTER JOIN
                         dbo.Departman ON dbo.Kullanici.DepartmanID = dbo.Departman.DepartmanID", baglanti))
        {
          da.Fill(dt);
          dataGridView1.DataSource = dt;
        }
      }
      catch (Exception hata)
      {
        MessageBox.Show(hata.Message);
      }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      kullanici.frmKullaniciDetay frmKullaniciDetay = new frmKullaniciDetay("-1");
      if (frmKullaniciDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }
    private void btnSil_Click(object sender, EventArgs e)
    {

    }
    private void btnDegistir_Click(object sender, EventArgs e)
    {
      //grid de bir satır seçilmemişse işlem yapmasın
      if (dataGridView1.SelectedRows.Count < 1) return;

      kullanici.frmKullaniciDetay frmKullaniciDetay = new frmKullaniciDetay(
        dataGridView1.SelectedRows[0].Cells["KullaniciID"].Value.ToString()
        );
      if (frmKullaniciDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        dt.Clear();
        da.Fill(dt);
      }
    }
  }
}
