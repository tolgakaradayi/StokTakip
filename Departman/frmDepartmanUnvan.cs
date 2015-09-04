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
  public partial class frmDepartmanUnvan : DevExpress.XtraEditors.XtraForm
  {
    public frmDepartmanUnvan()
    {
      InitializeComponent();
    }
    SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();
    BindingSource bs = new BindingSource();

    int satirNo = 0;

    //islem içinde true değer varsa insert, false değer varsa update komutu çalıştırılacak.
    bool islem = true;

    private void frmDepartmanUnvan_Load(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        #region lkpDepartman dolduruluyor.
        using (var daDepartman = new SqlDataAdapter(@"Select DepartmanID, DepartmanTanim From Departman ORder by DepartmanTanim asc", baglanti))
        {
          var dtDepartman = new DataTable();
          daDepartman.Fill(dtDepartman);

          lkpDepartman.Properties.DataSource = dtDepartman;
          lkpDepartman.Properties.PopulateColumns();// da dan gelen kolonların lookup ta oluşturulmasını sağlar.

          // dt nin işaretlediği kolonların hangisinin son kullanıcı hangisinin programcı tarafından erişileceğine karar verir.
          lkpDepartman.Properties.ValueMember = "DepartmanID";  // satır seçildiğinde programcıya gidecek değer
          lkpDepartman.Properties.DisplayMember = "DepartmanTanim";// satır seçildiğinde son kullanıcıya gösterilecek değer

          lkpDepartman.Properties.Columns["DepartmanID"].Visible = false;
          lkpDepartman.Properties.Columns["DepartmanTanim"].Caption = "Departman Tanım";

          lkpDepartman.EditValue = -1; // lookup ta boş satır gelmesini sağladık
        }
        #endregion

        NesneEnabled(false);
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }

    //void -> çağrılan fonksiyon geriye cevap dönmesin.
    void NesneEnabled(bool islem)
    {
      btnEkle.Enabled = !islem;
      btnSil.Enabled = !islem;
      btnDegistir.Enabled = !islem;

      btnVazgec.Enabled = islem;
      btnKaydet.Enabled = islem;

      txtUnvanTanim.Enabled = islem;
      gcListe.Enabled = !islem;

      btnGuncelle.Enabled = islem;
    }

    private void lkpDepartman_EditValueChanged(object sender, EventArgs e)
    {
      try
      {
        if (baglanti.State == ConnectionState.Closed) baglanti.Open();

        using (da.SelectCommand = new SqlCommand(@"SELECT Unvan2ID, DepartmanID, UnvanTanim
FROM dbo.Unvan2 WHERE (DepartmanID = @DepartmanID)", baglanti))
        {
          da.SelectCommand.Parameters.Add("@DepartmanID", SqlDbType.Int).Value = lkpDepartman.EditValue.ToString();
          dt.Clear();
          da.Fill(dt);
          bs.DataSource = dt;

          gcListe.DataSource = bs;

          txtUnvanTanim.DataBindings.Clear();
          txtUnvanTanim.DataBindings.Add("Text", bs, "UnvanTanim");

          //Grid kolonları ile ilgili değişiklikler burda yapılacak.
          gvListe.Columns["Unvan2ID"].Visible = false;
          gvListe.Columns["DepartmanID"].Visible = false;

          gvListe.Columns["UnvanTanim"].Caption = "Ünvan Tanım";
        }
      }
      catch (Exception hata)
      {
        throw new Exception(hata.Message);
      }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      //eğer departman seçilmemişse işlem yaptırma
      if (lkpDepartman.EditValue.ToString() == "-1")
      {
        XtraMessageBox.Show("Önce Departman seçiniz.");
        lkpDepartman.Focus();
        return;
      }

      NesneEnabled(true);
      txtUnvanTanim.Text = "";
      txtUnvanTanim.Focus();

      islem = true;//insert işlemi olduğunu belirtiyoruz
    }

    private void btnSil_Click(object sender, EventArgs e)
    {

    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {
      //eğer departman seçilmemişse işlem yaptırma
      if (lkpDepartman.EditValue.ToString() == "-1")
      {
        XtraMessageBox.Show("Önce Departman seçiniz.");
        lkpDepartman.Focus();
        return;
      }

      NesneEnabled(true);
      txtUnvanTanim.Focus();
      //gvListe.FocusedRowHandle; -> o andaki gridde seçili olan satırın indis numarasını verir.
      satirNo = gvListe.FocusedRowHandle;

      islem = false;//update işlemi olduğunu belirtiyoruz
    }

    private void btnVazgec_Click(object sender, EventArgs e)
    {
      NesneEnabled(false);
      btnGuncelle_Click(null, null);
      if (!islem) gvListe.FocusedRowHandle = satirNo;
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtUnvanTanim.Text == "")
        {
          XtraMessageBox.Show("Zorunlu alanlar boş geçilemez");
          txtUnvanTanim.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = baglanti;
        cmd.CommandType = CommandType.Text;

        if (islem)
        {
          //insert
          cmd.CommandText = "Insert Into Unvan2(DepartmanID, UnvanTanim) values(@DepartmanID, @UnvanTanim)";
        }
        else
        { 
        //update
          cmd.CommandText = "Update Unvan2 SET DepartmanID=@DepartmanID, UnvanTanim=@UnvanTanim Where Unvan2ID=@Unvan2ID";
          cmd.Parameters.Add("@Unvan2ID", SqlDbType.Int).Value = gvListe.GetFocusedRowCellDisplayText("Unvan2ID");
        }

        cmd.Parameters.Add("DepartmanID", SqlDbType.Int).Value = lkpDepartman.EditValue;
        cmd.Parameters.Add("UnvanTanim", SqlDbType.VarChar).Value = txtUnvanTanim.Text;

        cmd.ExecuteNonQuery();
        
        btnGuncelle_Click(null, null);
        NesneEnabled(false);
        if (!islem) gvListe.FocusedRowHandle = satirNo;
      }
      catch (Exception hata)
      {
        XtraMessageBox.Show(hata.Message);
      }
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      dt.Clear();
      da.Fill(dt);
    }
  }
}