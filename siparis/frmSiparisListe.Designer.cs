namespace Proje_BilisimERP.siparis
{
  partial class frmSiparisListe
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisListe));
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
      this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
      this.btnSil = new DevExpress.XtraEditors.SimpleButton();
      this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
      this.gcListe = new DevExpress.XtraGrid.GridControl();
      this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cbtnSatiriYazdir = new System.Windows.Forms.ToolStripMenuItem();
      this.cbtnRaporDizayn = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      this.cmsMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.btnExcel);
      this.panelControl1.Controls.Add(this.btnDegistir);
      this.panelControl1.Controls.Add(this.btnSil);
      this.panelControl1.Controls.Add(this.btnEkle);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelControl1.Location = new System.Drawing.Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(565, 43);
      this.panelControl1.TabIndex = 0;
      // 
      // btnExcel
      // 
      this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
      this.btnExcel.Location = new System.Drawing.Point(300, 2);
      this.btnExcel.Name = "btnExcel";
      this.btnExcel.Size = new System.Drawing.Size(100, 38);
      this.btnExcel.TabIndex = 7;
      this.btnExcel.Text = "Excel";
      this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
      // 
      // btnDegistir
      // 
      this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Image")));
      this.btnDegistir.Location = new System.Drawing.Point(200, 2);
      this.btnDegistir.Name = "btnDegistir";
      this.btnDegistir.Size = new System.Drawing.Size(100, 38);
      this.btnDegistir.TabIndex = 6;
      this.btnDegistir.Text = "Değiştir";
      this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
      // 
      // btnSil
      // 
      this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
      this.btnSil.Location = new System.Drawing.Point(100, 2);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(100, 38);
      this.btnSil.TabIndex = 5;
      this.btnSil.Text = "Sil";
      // 
      // btnEkle
      // 
      this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
      this.btnEkle.Location = new System.Drawing.Point(0, 2);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(100, 38);
      this.btnEkle.TabIndex = 4;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // gcListe
      // 
      this.gcListe.ContextMenuStrip = this.cmsMenu;
      this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcListe.Location = new System.Drawing.Point(0, 43);
      this.gcListe.MainView = this.gvListe;
      this.gcListe.Name = "gcListe";
      this.gcListe.Size = new System.Drawing.Size(565, 377);
      this.gcListe.TabIndex = 1;
      this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
      // 
      // gvListe
      // 
      this.gvListe.GridControl = this.gcListe;
      this.gvListe.Name = "gvListe";
      // 
      // cmsMenu
      // 
      this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnSatiriYazdir,
            this.cbtnRaporDizayn});
      this.cmsMenu.Name = "contextMenuStrip1";
      this.cmsMenu.Size = new System.Drawing.Size(153, 70);
      // 
      // cbtnSatiriYazdir
      // 
      this.cbtnSatiriYazdir.Name = "cbtnSatiriYazdir";
      this.cbtnSatiriYazdir.Size = new System.Drawing.Size(152, 22);
      this.cbtnSatiriYazdir.Text = "Satırı Yazdır";
      this.cbtnSatiriYazdir.Click += new System.EventHandler(this.cbtnSatiriYazdir_Click);
      // 
      // cbtnRaporDizayn
      // 
      this.cbtnRaporDizayn.Name = "cbtnRaporDizayn";
      this.cbtnRaporDizayn.Size = new System.Drawing.Size(152, 22);
      this.cbtnRaporDizayn.Text = "Rapor Dizayn";
      this.cbtnRaporDizayn.Click += new System.EventHandler(this.cbtnRaporDizayn_Click);
      // 
      // frmSiparisListe
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(565, 420);
      this.Controls.Add(this.gcListe);
      this.Controls.Add(this.panelControl1);
      this.Name = "frmSiparisListe";
      this.Text = "Sipariş Liste";
      this.Load += new System.EventHandler(this.frmSiparisListe_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.cmsMenu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraEditors.SimpleButton btnExcel;
    private DevExpress.XtraEditors.SimpleButton btnDegistir;
    private DevExpress.XtraEditors.SimpleButton btnSil;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
    private System.Windows.Forms.ContextMenuStrip cmsMenu;
    private System.Windows.Forms.ToolStripMenuItem cbtnSatiriYazdir;
    private System.Windows.Forms.ToolStripMenuItem cbtnRaporDizayn;
  }
}