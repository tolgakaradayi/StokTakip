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

namespace Proje_BilisimERP.Unvan
{
  public partial class frmUnvanDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmUnvanDetay(string UnvanID)
    {
      InitializeComponent();
      _UnvanID = UnvanID;
    }

    string _UnvanID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtUnvanTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alanlar boş geçilemez","Bilişim ERP",  MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtUnvanTanim.Focus();
          return;
        }
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;

        if (_UnvanID == "-1")
        {
          cmd.CommandText = "Insert Into Unvan values(@UnvanTanim)";
        }
        else
        {
          cmd.CommandText = "Update Unvan sET UnvanTanim=@UnvanTanim Where UnvanID=@UnvanID";
          cmd.Parameters.Add("@UnvanID", SqlDbType.Int).Value = _UnvanID;
        }

        cmd.Parameters.Add("@UnvanTanim", SqlDbType.VarChar).Value = txtUnvanTanim.Text;
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