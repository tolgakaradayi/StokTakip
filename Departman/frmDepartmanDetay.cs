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
  public partial class frmDepartmanDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmDepartmanDetay(string DepartmanID)
    {
      InitializeComponent();
      _DepartmanID = DepartmanID;
    }

    string _DepartmanID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtDepartmanTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alanlar boş geçilemez","Bilişim ERP",  MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtDepartmanTanim.Focus();
          return;
        }
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;

        if (_DepartmanID == "-1")
        {
          cmd.CommandText = "Insert Into Departman values(@DepartmanTanim)";
        }
        else
        {
          cmd.CommandText = "Update Departman sET DepartmanTanim=@DepartmanTanim Where DepartmanID=@DepartmanID";
          cmd.Parameters.Add("@DepartmanID", SqlDbType.Int).Value = _DepartmanID;
        }

        cmd.Parameters.Add("@DepartmanTanim", SqlDbType.VarChar).Value = txtDepartmanTanim.Text;
        cmd.ExecuteNonQuery();
        XtraMessageBox.Show("Kaydetme işlemi başarılı");
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }
  }
}