namespace Proje_BilisimERP.siparis
{
  partial class frmSiparisDetay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisDetay));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtCariGrupTanim = new DevExpress.XtraEditors.TextEdit();
			this.txtCariTanim = new DevExpress.XtraEditors.TextEdit();
			this.txtCariKodu = new DevExpress.XtraEditors.ButtonEdit();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.deSiparisTarihi = new DevExpress.XtraEditors.DateEdit();
			this.txtSiparisNo = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gcListe = new DevExpress.XtraGrid.GridControl();
			this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cbtnYeniSatir = new System.Windows.Forms.ToolStripMenuItem();
			this.gvListe = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSiparisDetayID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSiparisID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lkpStok = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colSiparisMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSatirToplam = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStokID2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtStokTanim = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCariGrupTanim.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCariTanim.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.deSiparisTarihi.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deSiparisTarihi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).BeginInit();
			this.cmsMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpStok)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStokTanim)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.btnKaydet);
			this.panelControl1.Controls.Add(this.panelControl3);
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(592, 116);
			this.panelControl1.TabIndex = 0;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(469, 74);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(100, 33);
			this.btnKaydet.TabIndex = 10;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// panelControl3
			// 
			this.panelControl3.Controls.Add(this.labelControl3);
			this.panelControl3.Controls.Add(this.txtCariGrupTanim);
			this.panelControl3.Controls.Add(this.txtCariTanim);
			this.panelControl3.Controls.Add(this.txtCariKodu);
			this.panelControl3.Location = new System.Drawing.Point(231, 8);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(214, 100);
			this.panelControl3.TabIndex = 1;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(6, 14);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(19, 13);
			this.labelControl3.TabIndex = 3;
			this.labelControl3.Text = "Cari";
			// 
			// txtCariGrupTanim
			// 
			this.txtCariGrupTanim.Location = new System.Drawing.Point(6, 63);
			this.txtCariGrupTanim.Name = "txtCariGrupTanim";
			this.txtCariGrupTanim.Size = new System.Drawing.Size(195, 20);
			this.txtCariGrupTanim.TabIndex = 2;
			// 
			// txtCariTanim
			// 
			this.txtCariTanim.Location = new System.Drawing.Point(6, 37);
			this.txtCariTanim.Name = "txtCariTanim";
			this.txtCariTanim.Size = new System.Drawing.Size(195, 20);
			this.txtCariTanim.TabIndex = 1;
			// 
			// txtCariKodu
			// 
			this.txtCariKodu.Location = new System.Drawing.Point(43, 10);
			this.txtCariKodu.Name = "txtCariKodu";
			this.txtCariKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.txtCariKodu.Size = new System.Drawing.Size(158, 20);
			this.txtCariKodu.TabIndex = 0;
			this.txtCariKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCariKodu_ButtonClick);
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.deSiparisTarihi);
			this.panelControl2.Controls.Add(this.txtSiparisNo);
			this.panelControl2.Controls.Add(this.labelControl2);
			this.panelControl2.Controls.Add(this.labelControl1);
			this.panelControl2.Location = new System.Drawing.Point(15, 8);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(209, 100);
			this.panelControl2.TabIndex = 0;
			// 
			// deSiparisTarihi
			// 
			this.deSiparisTarihi.EditValue = null;
			this.deSiparisTarihi.Location = new System.Drawing.Point(76, 36);
			this.deSiparisTarihi.Name = "deSiparisTarihi";
			this.deSiparisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deSiparisTarihi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.deSiparisTarihi.Size = new System.Drawing.Size(100, 20);
			this.deSiparisTarihi.TabIndex = 3;
			// 
			// txtSiparisNo
			// 
			this.txtSiparisNo.Location = new System.Drawing.Point(76, 10);
			this.txtSiparisNo.Name = "txtSiparisNo";
			this.txtSiparisNo.Size = new System.Drawing.Size(100, 20);
			this.txtSiparisNo.TabIndex = 2;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(6, 40);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Sipariş Tarihi";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(6, 14);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(47, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Sipariş No";
			// 
			// gcListe
			// 
			this.gcListe.ContextMenuStrip = this.cmsMenu;
			this.gcListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcListe.Location = new System.Drawing.Point(0, 116);
			this.gcListe.MainView = this.gvListe;
			this.gcListe.Name = "gcListe";
			this.gcListe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkpStok,
            this.txtStokTanim});
			this.gcListe.Size = new System.Drawing.Size(592, 352);
			this.gcListe.TabIndex = 1;
			this.gcListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListe});
			// 
			// cmsMenu
			// 
			this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbtnYeniSatir});
			this.cmsMenu.Name = "cmsMenu";
			this.cmsMenu.Size = new System.Drawing.Size(124, 26);
			// 
			// cbtnYeniSatir
			// 
			this.cbtnYeniSatir.Name = "cbtnYeniSatir";
			this.cbtnYeniSatir.Size = new System.Drawing.Size(123, 22);
			this.cbtnYeniSatir.Text = "Yeni Satır";
			this.cbtnYeniSatir.Click += new System.EventHandler(this.cbtnYeniSatir_Click);
			// 
			// gvListe
			// 
			this.gvListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSiparisDetayID,
            this.colSiparisID,
            this.colStokID,
            this.colSiparisMiktar,
            this.colBirimFiyat,
            this.colSatirToplam,
            this.colStokID2});
			this.gvListe.GridControl = this.gcListe;
			this.gvListe.Name = "gvListe";
			this.gvListe.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvListe_CellValueChanged);
			// 
			// colSiparisDetayID
			// 
			this.colSiparisDetayID.Caption = "SiparisDetayID";
			this.colSiparisDetayID.FieldName = "SiparisDetayID";
			this.colSiparisDetayID.Name = "colSiparisDetayID";
			this.colSiparisDetayID.Visible = true;
			this.colSiparisDetayID.VisibleIndex = 0;
			// 
			// colSiparisID
			// 
			this.colSiparisID.Caption = "SiparisID";
			this.colSiparisID.FieldName = "SiparisID";
			this.colSiparisID.Name = "colSiparisID";
			this.colSiparisID.Visible = true;
			this.colSiparisID.VisibleIndex = 1;
			// 
			// colStokID
			// 
			this.colStokID.Caption = "StokID";
			this.colStokID.ColumnEdit = this.lkpStok;
			this.colStokID.FieldName = "StokID";
			this.colStokID.Name = "colStokID";
			this.colStokID.Visible = true;
			this.colStokID.VisibleIndex = 2;
			// 
			// lkpStok
			// 
			this.lkpStok.AutoHeight = false;
			this.lkpStok.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lkpStok.Name = "lkpStok";
			this.lkpStok.NullText = "";
			// 
			// colSiparisMiktar
			// 
			this.colSiparisMiktar.Caption = "SiparisMiktar";
			this.colSiparisMiktar.FieldName = "SiparisMiktar";
			this.colSiparisMiktar.Name = "colSiparisMiktar";
			this.colSiparisMiktar.Visible = true;
			this.colSiparisMiktar.VisibleIndex = 3;
			// 
			// colBirimFiyat
			// 
			this.colBirimFiyat.Caption = "BirimFiyat";
			this.colBirimFiyat.FieldName = "BirimFiyat";
			this.colBirimFiyat.Name = "colBirimFiyat";
			this.colBirimFiyat.Visible = true;
			this.colBirimFiyat.VisibleIndex = 4;
			// 
			// colSatirToplam
			// 
			this.colSatirToplam.Caption = "SatirToplam";
			this.colSatirToplam.FieldName = "SatirToplam";
			this.colSatirToplam.Name = "colSatirToplam";
			this.colSatirToplam.Visible = true;
			this.colSatirToplam.VisibleIndex = 5;
			// 
			// colStokID2
			// 
			this.colStokID2.Caption = "StokID2";
			this.colStokID2.ColumnEdit = this.txtStokTanim;
			this.colStokID2.FieldName = "StokID2";
			this.colStokID2.Name = "colStokID2";
			this.colStokID2.Visible = true;
			this.colStokID2.VisibleIndex = 6;
			// 
			// txtStokTanim
			// 
			this.txtStokTanim.AutoHeight = false;
			this.txtStokTanim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.txtStokTanim.Name = "txtStokTanim";
			this.txtStokTanim.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtStokTanim_ButtonClick);
			// 
			// frmSiparisDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 468);
			this.Controls.Add(this.gcListe);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmSiparisDetay";
			this.Text = "Sipariş Detay";
			this.Load += new System.EventHandler(this.frmSiparisDetay_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			this.panelControl3.ResumeLayout(false);
			this.panelControl3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCariGrupTanim.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCariTanim.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.deSiparisTarihi.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deSiparisTarihi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSiparisNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcListe)).EndInit();
			this.cmsMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lkpStok)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStokTanim)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraGrid.GridControl gcListe;
    private DevExpress.XtraGrid.Views.Grid.GridView gvListe;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.DateEdit deSiparisTarihi;
    private DevExpress.XtraEditors.TextEdit txtSiparisNo;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.PanelControl panelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    public DevExpress.XtraEditors.TextEdit txtCariGrupTanim;
    public DevExpress.XtraEditors.TextEdit txtCariTanim;
    public DevExpress.XtraEditors.ButtonEdit txtCariKodu;
    private System.Windows.Forms.ContextMenuStrip cmsMenu;
    private System.Windows.Forms.ToolStripMenuItem cbtnYeniSatir;
    private DevExpress.XtraGrid.Columns.GridColumn colSiparisDetayID;
    private DevExpress.XtraGrid.Columns.GridColumn colSiparisID;
    private DevExpress.XtraGrid.Columns.GridColumn colStokID;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkpStok;
    private DevExpress.XtraGrid.Columns.GridColumn colSiparisMiktar;
    private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
    private DevExpress.XtraGrid.Columns.GridColumn colSatirToplam;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraGrid.Columns.GridColumn colStokID2;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit txtStokTanim;
  }
}