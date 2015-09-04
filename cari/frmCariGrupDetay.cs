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
  public partial class frmCariGrupDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmCariGrupDetay(string CariGrupID)
    {
      InitializeComponent();
      _CariGrupID = CariGrupID;
    }

    string _CariGrupID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtCariGrupTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alanlar boş geçilemez","Bilişim ERP",  MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtCariGrupTanim.Focus();
          return;
        }
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;

        if (_CariGrupID == "-1")
        {
          cmd.CommandText = "Insert Into CariGrup values(@CariGrupTanim)";
        }
        else
        {
          cmd.CommandText = "Update CariGrup sET CariGrupTanim=@CariGrupTanim Where CariGrupID=@CariGrupID";
          cmd.Parameters.Add("@CariGrupID", SqlDbType.Int).Value = _CariGrupID;
        }

        cmd.Parameters.Add("@CariGrupTanim", SqlDbType.VarChar).Value = txtCariGrupTanim.Text;
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