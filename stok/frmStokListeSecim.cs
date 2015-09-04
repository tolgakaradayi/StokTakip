using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje_BilisimERP.stok
{
	public partial class frmStokListeSecim : DevExpress.XtraEditors.XtraForm
	{
		public frmStokListeSecim()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.DBConStr);
		SqlDataAdapter da = new SqlDataAdapter();
		DataTable dt = new DataTable();

		private void gvListe_DoubleClick(object sender, EventArgs e)
		{
	((siparis.frmSiparisDetay)Application.OpenForms["frmSiparisDetay"]).stokID = gvListe.GetFocusedRowCellDisplayText("StokID");
	((siparis.frmSiparisDetay)Application.OpenForms["frmSiparisDetay"]).stokTanim = gvListe.GetFocusedRowCellDisplayText("StokTanim");
	this.DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void frmStokListeSecim_Load(object sender, EventArgs e)
		{
			try
			{
				if (baglanti.State == ConnectionState.Closed) baglanti.Open();
				using (da.SelectCommand = new SqlCommand(@"SELECT        StokID, StokKodu, StokTanim
FROM            dbo.Stok", baglanti))
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
	}
}