using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje_BilisimERP.cari
{
  public partial class frmCariDetay : DevExpress.XtraEditors.XtraForm
  {
    public frmCariDetay(string cariID)
    {
      InitializeComponent();
      _cariID = cariID;
    }
    string _cariID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    private void frmCariDetay_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        #region lkpCariGrupDolduruluyor.
        using (SqlDataAdapter da = new SqlDataAdapter("Select CariGrupID, CariGrupTanim From CariGrup Order by CariGrupTanim asc", baglanti))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpCariGrup.Properties.DataSource = dt;

          lkpCariGrup.Properties.PopulateColumns();// kolonları dt den alıp lookup a aktar.
          lkpCariGrup.Properties.ValueMember = "CariGrupID";
          lkpCariGrup.Properties.DisplayMember = "CariGrupTanim";
          lkpCariGrup.Properties.Columns["CariGrupID"].Visible = false;
          lkpCariGrup.Properties.Columns["CariGrupTanim"].Caption = "Cari Grup Tanım";

          lkpCariGrup.EditValue = -1;
        }
        #endregion

        if (_cariID != "-1")
        {
          using (SqlCommand cmd = new SqlCommand(@"SELECT        CariID, CariKodu, CariTanim, CariGrupID
FROM            dbo.Cari WHERE        (CariID = @CariID)", baglanti))
          {
            cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = _cariID;

            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
              if (dr.Read())
              {
                txtCariKodu.Text = dr["CariKodu"].ToString();
                txtCariTanim.Text = dr["CariTanim"].ToString();

                if (dr["CariGrupID"] != DBNull.Value)
                  lkpCariGrup.EditValue = Convert.ToInt32(dr["CariGrupID"].ToString());

              }
            }
          }
        }
      }
      catch (Exception hata)
      {
        MessageBox.Show(hata.Message);
      }
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        #region Boş alan kontrolü
        if (txtCariKodu.Text == "")
        {
          MessageBox.Show("Zorunlu alanları boş geçilemez.");
          txtCariKodu.Focus();
          return;
        }
        if (txtCariTanim.Text == "")
        {
          MessageBox.Show("Zorunlu alanları boş geçilemez.");
          txtCariTanim.Focus();
          return;
        }
        if ((int)lkpCariGrup.EditValue == -1)
        {
          MessageBox.Show("Zorunlu alanları boş geçilemez.");
          lkpCariGrup.Focus();
          return;
        }
        #endregion

        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;

        if (_cariID == "-1")
        {
          //insert
          cmd.CommandText = "Insert Into Cari Values(@CariKodu, @CariTanim, @CariGrupID)";
        }
        else
        {
          //update
          cmd.CommandText = @"Update Cari SET CariKodu=@CariKodu, CariTanim=@CariTanim, CariGrupID=@CariGrupID Where CariID=@CariID";

          cmd.Parameters.Add("@CariID", SqlDbType.Int).Value = _cariID;
        }

        cmd.Parameters.Add("@CariKodu", SqlDbType.VarChar).Value = txtCariKodu.Text;
        cmd.Parameters.Add("@CariTanim", SqlDbType.VarChar).Value = txtCariTanim.Text;
        cmd.Parameters.Add("@CariGrupID", SqlDbType.Int).Value = lkpCariGrup.EditValue.ToString();


        cmd.ExecuteNonQuery();//Sorgusuz sualsiz çalıştır.
        cmd.Dispose();

        XtraMessageBox.Show("Kaydetme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.DialogResult = DialogResult.OK;
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
        //this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      }

    }
  }
}