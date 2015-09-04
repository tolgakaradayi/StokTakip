namespace Proje_BilisimERP.Departman
{
  partial class frmDepartmanUnvan
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanUnvan));
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.lkpDepartman = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
      this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
      this.btnSil = new DevExpress.XtraEditors.SimpleButton();
      this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
      this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.txtUnvanTanim = new DevExpress.XtraEditors.TextEdit();
      this.gcListe = new DevExpress.XtraGrid.GridControl();
      this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colUnvan2ID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDepartmanID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colUnvanTanim = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lkpDepartman.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
      this.panelControl3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtUnvanTanim.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.lkpDepartman);
      this.panelControl1.Controls.Add(this.labelControl2);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelControl1.Location = new System.Drawing.Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(427, 47);
      this.panelControl1.TabIndex = 0;
      // 
      // lkpDepartman
      // 
      this.lkpDepartman.Location = new System.Drawing.Point(86, 13);
      this.lkpDepartman.Name = "lkpDepartman";
      this.lkpDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lkpDepartman.Properties.NullText = "";
      this.lkpDepartman.Size = new System.Drawing.Size(159, 20);
      this.lkpDepartman.TabIndex = 1;
      this.lkpDepartman.EditValueChanged += new System.EventHandler(this.lkpDepartman_EditValueChanged);
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(5, 16);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(60, 13);
      this.labelControl2.TabIndex = 0;
      this.labelControl2.Text = "Departman :";
      // 
      // panelControl2
      // 
      this.panelControl2.Controls.Add(this.btnGuncelle);
      this.panelControl2.Controls.Add(this.btnKaydet);
      this.panelControl2.Controls.Add(this.btnVazgec);
      this.panelControl2.Controls.Add(this.btnDegistir);
      this.panelControl2.Controls.Add(this.btnSil);
      this.panelControl2.Controls.Add(this.btnEkle);
      this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl2.Location = new System.Drawing.Point(0, 343);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(427, 40);
      this.panelControl2.TabIndex = 1;
      // 
      // btnGuncelle
      // 
      this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
      this.btnGuncelle.Location = new System.Drawing.Point(351, 6);
      this.btnGuncelle.Name = "btnGuncelle";
      this.btnGuncelle.Size = new System.Drawing.Size(71, 30);
      this.btnGuncelle.TabIndex = 5;
      this.btnGuncelle.Text = "Güncelle";
      this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
      // 
      // btnKaydet
      // 
      this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
      this.btnKaydet.Location = new System.Drawing.Point(265, 6);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(65, 30);
      this.btnKaydet.TabIndex = 4;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // btnVazgec
      // 
      this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
      this.btnVazgec.Location = new System.Drawing.Point(200, 6);
      this.btnVazgec.Name = "btnVazgec";
      this.btnVazgec.Size = new System.Drawing.Size(65, 30);
      this.btnVazgec.TabIndex = 3;
      this.btnVazgec.Text = "Vazgeç";
      this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
      // 
      // btnDegistir
      // 
      this.btnDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.Image")));
      this.btnDegistir.Location = new System.Drawing.Point(135, 6);
      this.btnDegistir.Name = "btnDegistir";
      this.btnDegistir.Size = new System.Drawing.Size(65, 30);
      this.btnDegistir.TabIndex = 2;
      this.btnDegistir.Text = "Değiştir";
      this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
      // 
      // btnSil
      // 
      this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
      this.btnSil.Location = new System.Drawing.Point(70, 6);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(65, 30);
      this.btnSil.TabIndex = 1;
      this.btnSil.Text = "Sil";
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnEkle
      // 
      this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
      this.btnEkle.Location = new System.Drawing.Point(5, 6);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(65, 30);
      this.btnEkle.TabIndex = 0;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // panelControl3
      // 
      this.panelControl3.Controls.Add(this.labelControl1);
      this.panelControl3.Controls.Add(this.txtUnvanTanim);
      this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl3.Location = new System.Drawing.Point(0, 305);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new System.Drawing.Size(427, 38);
      this.panelControl3.TabIndex = 2;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(5, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(75, 13);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Ünvan2 Tanım :";
      // 
      // txtUnvanTanim
      // 
      this.txtUnvanTanim.Location = new System.Drawing.Point(86, 9);
      this.txtUnvanTanim.Name = "txtUnvanTanim";
      this.txtUnvanTanim.Size = new System.Drawing.Size(244, 20);
      this.txtUnvanTanim.TabIndex = 0;
      // 
      // gcListe
      // 
      this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcListe.Location = new System.Drawing.Point(0, 47);
      this.gcListe.MainView = this.gvListe;
      this.gcListe.Name = "gcListe";
      this.gcListe.Size = new System.Drawing.Size(427, 258);
      this.gcListe.TabIndex = 3;
      this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
      // 
      // gvListe
      // 
      this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnvan2ID,
            this.colDepartmanID,
            this.colUnvanTanim});
      this.gvListe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gvListe.GridControl = this.gcListe;
      this.gvListe.Name = "gvListe";
      this.gvListe.OptionsBehavior.AllowIncrementalSearch = true;
      this.gvListe.OptionsBehavior.Editable = false;
      this.gvListe.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gvListe.OptionsSelection.EnableAppearanceFocusedRow = false;
      this.gvListe.OptionsView.ColumnAutoWidth = false;
      this.gvListe.OptionsView.ShowGroupPanel = false;
      // 
      // colUnvan2ID
      // 
      this.colUnvan2ID.Caption = "Unvan2ID";
      this.colUnvan2ID.FieldName = "Unvan2ID";
      this.colUnvan2ID.Name = "colUnvan2ID";
      this.colUnvan2ID.Visible = true;
      this.colUnvan2ID.VisibleIndex = 0;
      // 
      // colDepartmanID
      // 
      this.colDepartmanID.Caption = "DepartmanID";
      this.colDepartmanID.FieldName = "DepartmanID";
      this.colDepartmanID.Name = "colDepartmanID";
      this.colDepartmanID.Visible = true;
      this.colDepartmanID.VisibleIndex = 1;
      // 
      // colUnvanTanim
      // 
      this.colUnvanTanim.Caption = "Ünvan Tanım";
      this.colUnvanTanim.FieldName = "UnvanTanim";
      this.colUnvanTanim.Name = "colUnvanTanim";
      this.colUnvanTanim.Visible = true;
      this.colUnvanTanim.VisibleIndex = 2;
      this.colUnvanTanim.Width = 197;
      // 
      // frmDepartmanUnvan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(427, 383);
      this.Controls.Add(this.gcListe);
      this.Controls.Add(this.panelControl3);
      this.Controls.Add(this.panelControl2);
      this.Controls.Add(this.panelControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmDepartmanUnvan";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Departman a bağlı ünvanlar";
      this.Load += new System.EventHandler(this.frmDepartmanUnvan_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      this.panelControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lkpDepartman.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
      this.panelControl3.ResumeLayout(false);
      this.panelControl3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtUnvanTanim.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.SimpleButton btnVazgec;
    private DevExpress.XtraEditors.SimpleButton btnDegistir;
    private DevExpress.XtraEditors.SimpleButton btnSil;
    private DevExpress.XtraEditors.SimpleButton btnEkle;
    private DevExpress.XtraEditors.PanelControl panelControl3;
    private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit txtUnvanTanim;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraEditors.LookUpEdit lkpDepartman;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraGrid.Columns.GridColumn colUnvan2ID;
    private DevExpress.XtraGrid.Columns.GridColumn colDepartmanID;
    private DevExpress.XtraGrid.Columns.GridColumn colUnvanTanim;
  }
}