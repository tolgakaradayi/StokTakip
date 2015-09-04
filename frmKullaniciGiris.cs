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

namespace Proje_BilisimERP
{
  public partial class frmKullaniciGiris : Form
  {
    public frmKullaniciGiris()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    public string kullaniciID = "-1", kullaniciKodu = "";

    private void btnIptal_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnGiris_Click(object sender, EventArgs e)
    {
      try
      {
        #region Boş alan kontrolü
        if (txtKullaniciKodu.Text == "")
        {
          MessageBox.Show("Kullanıcı Kodunu giriniz");
          txtKullaniciKodu.Focus();
          return;
        }
        if (txtKullaniciSifre.Text == "")
        {
          MessageBox.Show("Kullanıcı Şifre giriniz");
          txtKullaniciSifre.Focus();
          return;
        }
        #endregion

        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        bool giris = false;

        using (SqlCommand cmd = new SqlCommand(@"SELECT        KullaniciID, KullaniciKodu, KullaniciSifre, DepartmanID, Aktif
FROM            dbo.Kullanici
WHERE        (KullaniciKodu = @KullaniciKodu) AND (KullaniciSifre = @KullaniciSifre) AND (Aktif = 1) ", baglanti))
        {
          cmd.Parameters.Add("@KullaniciKodu", SqlDbType.VarChar).Value = txtKullaniciKodu.Text;
          cmd.Parameters.Add("@KullaniciSifre", SqlDbType.VarChar).Value = txtKullaniciSifre.Text;

          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            if (dr.Read())
            {
              giris = true;
              kullaniciID = dr["KullaniciID"].ToString();
              kullaniciKodu = dr["KullaniciKodu"].ToString();

              cs.csKullanici.kullaniciKodu = dr["KullaniciKodu"].ToString();
              cs.csKullanici.kullaniciID = dr["KullaniciID"].ToString();
            }
          }
        }
        if (giris)
        {
          //Ana Forma yönlendirme işlemi yapılacak.

          //frmAnaForm frmAnaForm = new frmAnaForm();
          //this.Hide();
          //frmAnaForm.Show();

          frmAnaFormRibbon frmAnaFormRibbon = new frmAnaFormRibbon();
          //frmAnaFormRibbon.lblKullaniciBilgileri.Caption = "Giriş Yapan Kullanıcı : " + kullaniciKodu;
          this.Hide();
          frmAnaFormRibbon.Show();
        }
        else
        {
          MessageBox.Show("Kullanıcı Adı veya Şifre hatalı yada Kullanıcı Pasif");
        }
      }
      catch (Exception hata)
      {
        MessageBox.Show(hata.Message);
      }
    }

    public void ProgramiKapat()
    {
      this.Close();
    }
  }
}
