namespace Proje_BilisimERP
{
  partial class frmAnaFormRibbon
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
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.btnDepartmanListe = new DevExpress.XtraBars.BarButtonItem();
      this.btnUnvan = new DevExpress.XtraBars.BarButtonItem();
      this.btnDepartmanUnvan = new DevExpress.XtraBars.BarButtonItem();
      this.lblKullaniciBilgileri = new DevExpress.XtraBars.BarStaticItem();
      this.btnStokListe = new DevExpress.XtraBars.BarButtonItem();
      this.btnCariGrupListe = new DevExpress.XtraBars.BarButtonItem();
      this.btnCariListe = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.btnSiparisListe = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
      this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.btnPivotRapor = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDepartmanListe,
            this.btnUnvan,
            this.btnDepartmanUnvan,
            this.lblKullaniciBilgileri,
            this.btnStokListe,
            this.btnCariGrupListe,
            this.btnCariListe,
            this.barButtonItem1,
            this.btnSiparisListe,
            this.btnPivotRapor});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 13;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
      this.ribbon.Size = new System.Drawing.Size(745, 144);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      // 
      // btnDepartmanListe
      // 
      this.btnDepartmanListe.Caption = "Departman";
      this.btnDepartmanListe.Id = 1;
      this.btnDepartmanListe.LargeWidth = 100;
      this.btnDepartmanListe.Name = "btnDepartmanListe";
      this.btnDepartmanListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
      this.btnDepartmanListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepartmanListe_ItemClick);
      // 
      // btnUnvan
      // 
      this.btnUnvan.Caption = "Ünvan";
      this.btnUnvan.Id = 2;
      this.btnUnvan.LargeWidth = 100;
      this.btnUnvan.Name = "btnUnvan";
      this.btnUnvan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
      this.btnUnvan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnvan_ItemClick);
      // 
      // btnDepartmanUnvan
      // 
      this.btnDepartmanUnvan.Caption = "Departman - Ünvan";
      this.btnDepartmanUnvan.Id = 4;
      this.btnDepartmanUnvan.LargeWidth = 100;
      this.btnDepartmanUnvan.Name = "btnDepartmanUnvan";
      this.btnDepartmanUnvan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
      this.btnDepartmanUnvan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepartmanUnvan_ItemClick);
      // 
      // lblKullaniciBilgileri
      // 
      this.lblKullaniciBilgileri.Caption = "barStaticItem1";
      this.lblKullaniciBilgileri.Id = 5;
      this.lblKullaniciBilgileri.Name = "lblKullaniciBilgileri";
      this.lblKullaniciBilgileri.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // btnStokListe
      // 
      this.btnStokListe.Caption = "Stok Liste";
      this.btnStokListe.Id = 6;
      this.btnStokListe.LargeWidth = 100;
      this.btnStokListe.Name = "btnStokListe";
      this.btnStokListe.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
      this.btnStokListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStokListe_ItemClick);
      // 
      // btnCariGrupListe
      // 
      this.btnCariGrupListe.Caption = "Cari Grup Liste";
      this.btnCariGrupListe.Id = 7;
      this.btnCariGrupListe.LargeWidth = 100;
      this.btnCariGrupListe.Name = "btnCariGrupListe";
      this.btnCariGrupListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
      this.btnCariGrupListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariGrupListe_ItemClick);
      // 
      // btnCariListe
      // 
      this.btnCariListe.Caption = "Cari Liste";
      this.btnCariListe.Id = 8;
      this.btnCariListe.LargeWidth = 100;
      this.btnCariListe.Name = "btnCariListe";
      this.btnCariListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
      this.btnCariListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariListe_ItemClick);
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "barButtonItem1";
      this.barButtonItem1.Id = 9;
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // btnSiparisListe
      // 
      this.btnSiparisListe.Caption = "Sipariş Liste";
      this.btnSiparisListe.Id = 10;
      this.btnSiparisListe.LargeWidth = 100;
      this.btnSiparisListe.Name = "btnSiparisListe";
      this.btnSiparisListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
      this.btnSiparisListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSiparisListe_ItemClick);
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "Tanımlamalar";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.btnDepartmanListe);
      this.ribbonPageGroup1.ItemLinks.Add(this.btnUnvan);
      this.ribbonPageGroup1.ItemLinks.Add(this.btnDepartmanUnvan);
      this.ribbonPageGroup1.ItemLinks.Add(this.btnStokListe);
      this.ribbonPageGroup1.ItemLinks.Add(this.btnCariGrupListe);
      this.ribbonPageGroup1.ItemLinks.Add(this.btnCariListe);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.ShowCaptionButton = false;
      // 
      // ribbonPage2
      // 
      this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
      this.ribbonPage2.Name = "ribbonPage2";
      this.ribbonPage2.Text = "Sipariş";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.btnSiparisListe);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "ribbonPageGroup2";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.ItemLinks.Add(this.lblKullaniciBilgileri);
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 500);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(745, 31);
      // 
      // xtraTabbedMdiManager1
      // 
      this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
      this.xtraTabbedMdiManager1.MdiParent = this;
      // 
      // ribbonPageGroup3
      // 
      this.ribbonPageGroup3.ItemLinks.Add(this.btnPivotRapor);
      this.ribbonPageGroup3.Name = "ribbonPageGroup3";
      this.ribbonPageGroup3.Text = "ribbonPageGroup3";
      // 
      // btnPivotRapor
      // 
      this.btnPivotRapor.Caption = "Satış Pivot Raporu";
      this.btnPivotRapor.Id = 12;
      this.btnPivotRapor.LargeWidth = 100;
      this.btnPivotRapor.Name = "btnPivotRapor";
      this.btnPivotRapor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
      this.btnPivotRapor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPivotRapor_ItemClick_1);
      // 
      // frmAnaFormRibbon
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(745, 531);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribbon);
      this.IsMdiContainer = true;
      this.Name = "frmAnaFormRibbon";
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Bilişim ERP";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaFormRibbon_FormClosed);
      this.Load += new System.EventHandler(this.frmAnaFormRibbon_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonItem btnDepartmanListe;
    private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    private DevExpress.XtraBars.BarButtonItem btnUnvan;
    private DevExpress.XtraBars.BarButtonItem btnDepartmanUnvan;
    public DevExpress.XtraBars.BarStaticItem lblKullaniciBilgileri;
    private DevExpress.XtraBars.BarButtonItem btnStokListe;
    private DevExpress.XtraBars.BarButtonItem btnCariGrupListe;
    private DevExpress.XtraBars.BarButtonItem btnCariListe;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarButtonItem btnSiparisListe;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.BarButtonItem btnPivotRapor;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
  }
}