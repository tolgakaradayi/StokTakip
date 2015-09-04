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
  public partial class frmPivotRapor : DevExpress.XtraEditors.XtraForm
  {
    public frmPivotRapor()
    {
      InitializeComponent();
    }

    private void frmPivotRapor_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dsSpias.vwSiparis' table. You can move, or remove it, as needed.
      this.vwSiparisTableAdapter.Fill(this.dsSpias.vwSiparis);

    }
  }
}