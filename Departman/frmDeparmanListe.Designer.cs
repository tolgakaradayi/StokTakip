namespace Proje_BilisimERP.Departman
{
  partial class frmDeparmanListe
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeparmanListe));
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
      this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
      this.btnSil = new DevExpress.XtraEditors.SimpleButton();
      this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
      this.gcListe = new DevExpress.XtraGrid.GridControl();
      this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colDepartmanID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDepartmanTanim = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
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
      this.panelControl1.Size = new System.Drawing.Size(534, 51);
      this.panelControl1.TabIndex = 0;
      // 
      // btnExcel
      // 
      this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
      this.btnExcel.Location = new System.Drawing.Point(312, 6);
      this.btnExcel.Name = "btnExcel";
      this.btnExcel.Size = new System.Drawing.Size(100, 38);
      this.btnExcel.TabIndex = 3;
      this.btnExcel.Text = "Excel";
      this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
      // 
      // btnDegistir
      // 
      this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Image")));
      this.btnDegistir.Location = new System.Drawing.Point(212, 6);
      this.btnDegistir.Name = "btnDegistir";
      this.btnDegistir.Size = new System.Drawing.Size(100, 38);
      this.btnDegistir.TabIndex = 2;
      this.btnDegistir.Text = "Değiştir";
      this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
      // 
      // btnSil
      // 
      this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
      this.btnSil.Location = new System.Drawing.Point(112, 6);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(100, 38);
      this.btnSil.TabIndex = 1;
      this.btnSil.Text = "Sil";
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnEkle
      // 
      this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
      this.btnEkle.Location = new System.Drawing.Point(12, 6);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(100, 38);
      this.btnEkle.TabIndex = 0;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // gcListe
      // 
      this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcListe.Location = new System.Drawing.Point(0, 51);
      this.gcListe.MainView = this.gvListe;
      this.gcListe.Name = "gcListe";
      this.gcListe.Size = new System.Drawing.Size(534, 400);
      this.gcListe.TabIndex = 1;
      this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
      // 
      // gvListe
      // 
      this.gvListe.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.gvListe.Appearance.GroupFooter.Options.UseBackColor = true;
      this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmanID,
            this.colDepartmanTanim});
      this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gvListe.GridControl = this.gcListe;
      this.gvListe.Name = "gvListe";
      this.gvListe.OptionsBehavior.AllowIncrementalSearch = true;
      this.gvListe.OptionsBehavior.Editable = false;
      this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gvListe.OptionsSelection.EnableAppearanceFocusedRow = false;
      this.gvListe.OptionsView.ColumnAutoWidth = false;
      this.gvListe.OptionsView.EnableAppearanceEvenRow = true;
      this.gvListe.OptionsView.EnableAppearanceOddRow = true;
      this.gvListe.OptionsView.ShowFooter = true;
      this.gvListe.OptionsView.ShowGroupPanel = false;
      // 
      // colDepartmanID
      // 
      this.colDepartmanID.Caption = "Departman ID";
      this.colDepartmanID.FieldName = "DepartmanID";
      this.colDepartmanID.Name = "colDepartmanID";
      this.colDepartmanID.Visible = true;
      this.colDepartmanID.VisibleIndex = 0;
      this.colDepartmanID.Width = 155;
      // 
      // colDepartmanTanim
      // 
      this.colDepartmanTanim.Caption = "Departman Tanım";
      this.colDepartmanTanim.FieldName = "DepartmanTanim";
      this.colDepartmanTanim.Name = "colDepartmanTanim";
      this.colDepartmanTanim.Visible = true;
      this.colDepartmanTanim.VisibleIndex = 1;
      this.colDepartmanTanim.Width = 246;
      // 
      // frmDeparmanListe
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 451);
      this.Controls.Add(this.gcListe);
      this.Controls.Add(this.panelControl1);
      this.Name = "frmDeparmanListe";
      this.Text = "Departman Liste";
      this.Load += new System.EventHandler(this.frmDeparmanListe_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraGrid.Columns.GridColumn colDepartmanID;
    private DevExpress.XtraGrid.Columns.GridColumn colDepartmanTanim;
    private DevExpress.XtraEditors.SimpleButton btnExcel;
    private DevExpress.XtraEditors.SimpleButton btnDegistir;
    private DevExpress.XtraEditors.SimpleButton btnSil;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
  }
}