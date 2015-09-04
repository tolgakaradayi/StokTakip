using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje_BilisimERP.kullanici
{
  public partial class frmKullaniciDetay : Form
  {
    public frmKullaniciDetay(string kullaniciID)
    {
      InitializeComponent();
      _kullaniciID = kullaniciID;
    }
    string _kullaniciID = "-1";
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);

    private void frmKullaniciDetay_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        #region cmbDepartman dolduruluyor
        using (SqlDataAdapter da = new SqlDataAdapter("Select DepartmanID, DepartmanTanim From Departman Order by DepartmanTanim asc", baglanti))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);

          cmbDepartman.DataSource = dt; //combobox dolarken verileri dt den al
          cmbDepartman.ValueMember = "DepartmanID"; // cmb de bir satır seçildiğinde programcı seçilen bu satırdaki hangi kolon bilgisine ulaşsın.
          cmbDepartman.DisplayMember = "DepartmanTanim"; // cmb de bir satır seçildiğinde, son kullanıcı cmb de hangi kolon bilgisini görsün.
        }
        #endregion

        #region lkpDepartmanDolduruluyor.
        using (SqlDataAdapter da = new SqlDataAdapter("Select DepartmanID, DepartmanTanim From Departman Order by DepartmanTanim asc", baglanti))
        {
          DataTable dt = new DataTable();
          da.Fill(dt);
          lkpDepartman.Properties.DataSource = dt;

          lkpDepartman.Properties.PopulateColumns();// kolonları dt den alıp lookup a aktar.
          lkpDepartman.Properties.ValueMember = "DepartmanID";
          lkpDepartman.Properties.DisplayMember = "DepartmanTanim";
          lkpDepartman.Properties.Columns["DepartmanID"].Visible = false;
          lkpDepartman.Properties.Columns["DepartmanTanim"].Caption = "Departman Tanım";

          lkpDepartman.EditValue = -1;
        }
        #endregion

        if (_kullaniciID != "-1")
        {
          using (SqlCommand cmd = new SqlCommand(@"SELECT        dbo.Kullanici.KullaniciID, dbo.Kullanici.KullaniciKodu, dbo.Kullanici.KullaniciSifre, dbo.Kullanici.DepartmanID, dbo.Kullanici.Aktif, 
                         dbo.Departman.DepartmanTanim
FROM            dbo.Kullanici LEFT OUTER JOIN
                         dbo.Departman ON dbo.Kullanici.DepartmanID = dbo.Departman.DepartmanID
WHERE        (dbo.Kullanici.KullaniciID = @KullaniciID)", baglanti))
          {
            cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = _kullaniciID;

            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
            {
              if (dr.Read())
              {
                txtKullaniciKodu.Text = dr["KullaniciKodu"].ToString();
                txtKullaniciSifre.Text = dr["KullaniciSifre"].ToString();

                if (dr["DepartmanID"] != DBNull.Value)
                  lkpDepartman.EditValue = Convert.ToInt32(dr["DepartmanID"].ToString());
                //lkpDepartman.EditValue = (int)dr["DepartmanID"];

                //ceAktif.Checked = (bool)dr["Aktif"] ? true : false;
                ceAktif.Checked = (bool)dr["Aktif"];
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
        if (txtKullaniciKodu.Text == "")
        {
          MessageBox.Show("Zorunlu alanları boş geçilemez.");
          txtKullaniciKodu.Focus();
          return;
        }
        if (txtKullaniciSifre.Text == "")
        {
          MessageBox.Show("Zorunlu alanları boş geçilemez.");
          txtKullaniciSifre.Focus();
          return;
        }
        if ((int)lkpDepartman.EditValue == -1)
        {
          MessageBox.Show("Zorunlu alanları boş geçilemez.");
          lkpDepartman.Focus();
          return;
        }
        #endregion

        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;

        if (_kullaniciID == "-1")
        {
          //insert
          cmd.CommandText = "Insert Into Kullanici Values(@KullaniciKodu, @KullaniciSifre, @DepartmanID,@Aktif)";
        }
        else
        {
          //update
          cmd.CommandText = @"Update Kullanici SET KullaniciKodu=@KullaniciKodu, KullaniciSifre=@KullaniciSifre, DepartmanID=@DepartmanID, Aktif=@Aktif Where KullaniciID=@KullaniciID";

          cmd.Parameters.Add("@KullaniciID", SqlDbType.Int).Value = _kullaniciID;
        }

        cmd.Parameters.Add("@KullaniciKodu", SqlDbType.VarChar).Value = txtKullaniciKodu.Text;
        cmd.Parameters.Add("@KullaniciSifre", SqlDbType.VarChar).Value = txtKullaniciSifre.Text;
        cmd.Parameters.Add("@DepartmanID", SqlDbType.Int).Value = lkpDepartman.EditValue.ToString();

        cmd.Parameters.Add("@Aktif", SqlDbType.Bit).Value = ceAktif.Checked;

        cmd.ExecuteNonQuery();//Sorgusuz sualsiz çalıştır.
        cmd.Dispose();

        MessageBox.Show("Kaydetme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.DialogResult = DialogResult.OK;
      }
      catch (Exception hata)
      {
        MessageBox.Show(hata.Message);
        //this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      }
    }

    private void ceAktif_CheckedChanged(object sender, EventArgs e)
    {
      ceAktif.Text = ceAktif.Checked ? "Aktif" : "Pasif";
    }
  }
}
