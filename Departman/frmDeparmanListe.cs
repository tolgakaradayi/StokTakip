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

namespace Proje_BilisimERP.Departman
{
  public partial class frmDeparmanListe : DevExpress.XtraEditors.XtraForm
  {
    public frmDeparmanListe()
    {
      InitializeComponent();
    }

    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();

    private void frmDeparmanListe_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        using (da.SelectCommand = new SqlCommand(@"Select DepartmanID, DepartmanTanim From Departman", baglanti))
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

    private void btnEkle_Click(object sender, EventArgs e)
    {
      Departman.frmDepartmanDetay frmDepartmanDetay = new frmDepartmanDetay("-1");
      if (frmDepartmanDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

        if (XtraMessageBox.Show("Seçilen Satırı Silmek istediğinize emin misiniz?","Silme onayı",  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No) return;


        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        #region Seçililen Departman ın Kullanıcı Tablosunda kullanılıp kullanılmadığına bakıyoruz.
        bool kullaniliyor =false;

        using (SqlCommand cmd = new SqlCommand(@"Select KullaniciID From Kullanici Where DepartmanID=@DepartmanID", baglanti))
        {
          cmd.Parameters.Add("@DepartmanID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellDisplayText("DepartmanID");
          using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
          {
            if (dr.Read())
              kullaniliyor = true;
          }
        }

        if (kullaniliyor)
        {
          XtraMessageBox.Show("Seçilen Departman Kullanıcı Tablosunda Kullanılıyor.\nSilme işlemi iptal edilecek.","Bilişim ERP",  MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        #endregion


        #region Kullanılmayan Departman bilgisi siliniyor.
        using (SqlCommand cmd = new SqlCommand("Delete From Departman Where DepartmanID=@DepartmanID",baglanti))
        {
          cmd.Parameters.Add("@DepartmanID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellDisplayText("DepartmanID");

          cmd.ExecuteNonQuery();
        }
        #endregion

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
      Departman.frmDepartmanDetay frmDepartmanDetay = new Departman.frmDepartmanDetay(gvListe.GetFocusedRowCellDisplayText("DepartmanID"));
        frmDepartmanDetay.txtDepartmanTanim.Text = gvListe.GetFocusedRowCellDisplayText("DepartmanTanim");
        if (frmDepartmanDetay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
  }
}