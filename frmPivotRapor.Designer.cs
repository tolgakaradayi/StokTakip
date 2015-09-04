namespace Proje_BilisimERP
{
  partial class frmPivotRapor
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
      this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
      this.dsSpias = new Proje_BilisimERP.dsSpias();
      this.vwSiparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.vwSiparisTableAdapter = new Proje_BilisimERP.dsSpiasTableAdapters.vwSiparisTableAdapter();
      this.fieldSiparisNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldSiparisTarihi1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldSatirToplam1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldStokKodu1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldStokTanim1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCariKodu1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCariTanim1 = new DevExpress.XtraPivotGrid.PivotGridField();
      this.fieldCariGrupTanim1 = new DevExpress.XtraPivotGrid.PivotGridField();
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsSpias)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.vwSiparisBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // pivotGridControl1
      // 
      this.pivotGridControl1.DataSource = this.vwSiparisBindingSource;
      this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldSiparisNo1,
            this.fieldSiparisTarihi1,
            this.fieldSatirToplam1,
            this.fieldStokKodu1,
            this.fieldStokTanim1,
            this.fieldCariKodu1,
            this.fieldCariTanim1,
            this.fieldCariGrupTanim1});
      this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
      this.pivotGridControl1.Name = "pivotGridControl1";
      this.pivotGridControl1.Size = new System.Drawing.Size(491, 439);
      this.pivotGridControl1.TabIndex = 0;
      // 
      // dsSpias
      // 
      this.dsSpias.DataSetName = "dsSpias";
      this.dsSpias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // vwSiparisBindingSource
      // 
      this.vwSiparisBindingSource.DataMember = "vwSiparis";
      this.vwSiparisBindingSource.DataSource = this.dsSpias;
      // 
      // vwSiparisTableAdapter
      // 
      this.vwSiparisTableAdapter.ClearBeforeFill = true;
      // 
      // fieldSiparisNo1
      // 
      this.fieldSiparisNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.fieldSiparisNo1.AreaIndex = 2;
      this.fieldSiparisNo1.Caption = "Siparis No";
      this.fieldSiparisNo1.FieldName = "SiparisNo";
      this.fieldSiparisNo1.Name = "fieldSiparisNo1";
      // 
      // fieldSiparisTarihi1
      // 
      this.fieldSiparisTarihi1.AreaIndex = 0;
      this.fieldSiparisTarihi1.Caption = "Siparis Tarihi";
      this.fieldSiparisTarihi1.FieldName = "SiparisTarihi";
      this.fieldSiparisTarihi1.Name = "fieldSiparisTarihi1";
      // 
      // fieldSatirToplam1
      // 
      this.fieldSatirToplam1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
      this.fieldSatirToplam1.AreaIndex = 0;
      this.fieldSatirToplam1.Caption = "Satir Toplam";
      this.fieldSatirToplam1.FieldName = "SatirToplam";
      this.fieldSatirToplam1.Name = "fieldSatirToplam1";
      this.fieldSatirToplam1.Width = 144;
      // 
      // fieldStokKodu1
      // 
      this.fieldStokKodu1.AreaIndex = 1;
      this.fieldStokKodu1.Caption = "Stok Kodu";
      this.fieldStokKodu1.FieldName = "StokKodu";
      this.fieldStokKodu1.Name = "fieldStokKodu1";
      // 
      // fieldStokTanim1
      // 
      this.fieldStokTanim1.AreaIndex = 2;
      this.fieldStokTanim1.Caption = "Stok Tanim";
      this.fieldStokTanim1.FieldName = "StokTanim";
      this.fieldStokTanim1.Name = "fieldStokTanim1";
      // 
      // fieldCariKodu1
      // 
      this.fieldCariKodu1.AreaIndex = 3;
      this.fieldCariKodu1.Caption = "Cari Kodu";
      this.fieldCariKodu1.FieldName = "CariKodu";
      this.fieldCariKodu1.Name = "fieldCariKodu1";
      // 
      // fieldCariTanim1
      // 
      this.fieldCariTanim1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.fieldCariTanim1.AreaIndex = 1;
      this.fieldCariTanim1.Caption = "Cari Tanim";
      this.fieldCariTanim1.FieldName = "CariTanim";
      this.fieldCariTanim1.Name = "fieldCariTanim1";
      this.fieldCariTanim1.Width = 122;
      // 
      // fieldCariGrupTanim1
      // 
      this.fieldCariGrupTanim1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.fieldCariGrupTanim1.AreaIndex = 0;
      this.fieldCariGrupTanim1.Caption = "Cari Grup Tanim";
      this.fieldCariGrupTanim1.FieldName = "CariGrupTanim";
      this.fieldCariGrupTanim1.Name = "fieldCariGrupTanim1";
      this.fieldCariGrupTanim1.Width = 153;
      // 
      // frmPivotRapor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(491, 439);
      this.Controls.Add(this.pivotGridControl1);
      this.Name = "frmPivotRapor";
      this.Text = "frmPivotRapor";
      this.Load += new System.EventHandler(this.frmPivotRapor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsSpias)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.vwSiparisBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
    private dsSpias dsSpias;
    private System.Windows.Forms.BindingSource vwSiparisBindingSource;
    private dsSpiasTableAdapters.vwSiparisTableAdapter vwSiparisTableAdapter;
    private DevExpress.XtraPivotGrid.PivotGridField fieldSiparisNo1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldSiparisTarihi1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldSatirToplam1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldStokKodu1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldStokTanim1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCariKodu1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCariTanim1;
    private DevExpress.XtraPivotGrid.PivotGridField fieldCariGrupTanim1;
  }
}