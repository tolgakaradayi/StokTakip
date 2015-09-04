using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proje_BilisimERP
{
  public partial class frmExceleAktar : DevExpress.XtraEditors.XtraForm
  {
    public frmExceleAktar(DevExpress.XtraGrid.GridControl gelenGrid)
    {
      InitializeComponent();
      _gelenGrid = gelenGrid;
    }
    DevExpress.XtraGrid.GridControl _gelenGrid;

    private void frmExceleAktar_Load(object sender, EventArgs e)
    {
      try
      {
        sfdKaydet.Filter = "Excel Dosyası |*.xls";

        if (sfdKaydet.ShowDialog() == DialogResult.OK)
        {
          DevExpress.XtraPrinting.XlsExportOptions a = new DevExpress.XtraPrinting.XlsExportOptions();
          //excel içinde tek sayfaya mı yazsın?
          a.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile;
          //grid teki çizikler, excel de gösterilsin mi?
          a.ShowGridLines = true;
          //grid deki hangi bilgiler excel e gönderilsin. value-> gizli olan bilgiler de gitsin.
          a.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value;
          //grid deki http linkleri excel e aktarılsın mı?
          a.ExportHyperlinks = true;
          //excel in satır ve kolon satır sayısı hataları oluşursa, sana haber vereyim mi ?
          a.Suppress256ColumnsWarning = true;
          a.Suppress65536RowsWarning = true;

          //grid görünümünü seçilen excel dosyasına, belirtilen özelliklerle birlikte kaydet.
          _gelenGrid.ExportToXls(sfdKaydet.FileName, a);

          if (sfdKaydet.FileName != ".xls")
            if (XtraMessageBox.Show("Kaydetme işlemi başarılı.\nDosya Açılsın mı?", "Bilişim ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
              System.Diagnostics.Process.Start(sfdKaydet.FileName);
        }
        this.Close();
      }
      catch (Exception hata)
      {

        throw new Exception(hata.Message);
      }
    }
  }
}