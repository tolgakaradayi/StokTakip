namespace Proje_BilisimERP.stok
{
  partial class frmStokDetay
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokDetay));
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
      this.txtStokTanim = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.txtStokMinMiktar = new DevExpress.XtraEditors.TextEdit();
      this.txtStokMiktar = new DevExpress.XtraEditors.TextEdit();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
      this.peStokResim = new DevExpress.XtraEditors.PictureEdit();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokTanim.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokMinMiktar.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokMiktar.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.peStokResim.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.labelControl3);
      this.panelControl1.Controls.Add(this.labelControl4);
      this.panelControl1.Controls.Add(this.txtStokTanim);
      this.panelControl1.Controls.Add(this.txtStokKodu);
      this.panelControl1.Controls.Add(this.labelControl2);
      this.panelControl1.Controls.Add(this.labelControl1);
      this.panelControl1.Location = new System.Drawing.Point(179, 12);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(265, 62);
      this.panelControl1.TabIndex = 0;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(8, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(48, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Stok Kodu";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(8, 38);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(52, 13);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Stok Tanım";
      // 
      // txtStokKodu
      // 
      this.txtStokKodu.Location = new System.Drawing.Point(88, 8);
      this.txtStokKodu.Name = "txtStokKodu";
      this.txtStokKodu.Size = new System.Drawing.Size(158, 20);
      this.txtStokKodu.TabIndex = 0;
      this.txtStokKodu.Enter += new System.EventHandler(this.AktifTextBox);
      this.txtStokKodu.Leave += new System.EventHandler(this.PasifTextBox);
      // 
      // txtStokTanim
      // 
      this.txtStokTanim.Location = new System.Drawing.Point(88, 34);
      this.txtStokTanim.Name = "txtStokTanim";
      this.txtStokTanim.Size = new System.Drawing.Size(158, 20);
      this.txtStokTanim.TabIndex = 1;
      this.txtStokTanim.Enter += new System.EventHandler(this.AktifTextBox);
      this.txtStokTanim.Leave += new System.EventHandler(this.PasifTextBox);
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(78, 38);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(4, 13);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = ":";
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(78, 12);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(4, 13);
      this.labelControl4.TabIndex = 4;
      this.labelControl4.Text = ":";
      // 
      // panelControl2
      // 
      this.panelControl2.Controls.Add(this.labelControl5);
      this.panelControl2.Controls.Add(this.labelControl6);
      this.panelControl2.Controls.Add(this.txtStokMinMiktar);
      this.panelControl2.Controls.Add(this.txtStokMiktar);
      this.panelControl2.Controls.Add(this.labelControl7);
      this.panelControl2.Controls.Add(this.labelControl8);
      this.panelControl2.Location = new System.Drawing.Point(179, 80);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(265, 62);
      this.panelControl2.TabIndex = 1;
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(78, 38);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(4, 13);
      this.labelControl5.TabIndex = 5;
      this.labelControl5.Text = ":";
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(78, 12);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(4, 13);
      this.labelControl6.TabIndex = 4;
      this.labelControl6.Text = ":";
      // 
      // txtStokMinMiktar
      // 
      this.txtStokMinMiktar.Location = new System.Drawing.Point(88, 34);
      this.txtStokMinMiktar.Name = "txtStokMinMiktar";
      this.txtStokMinMiktar.Size = new System.Drawing.Size(158, 20);
      this.txtStokMinMiktar.TabIndex = 1;
      this.txtStokMinMiktar.Enter += new System.EventHandler(this.AktifTextBox);
      this.txtStokMinMiktar.Leave += new System.EventHandler(this.PasifTextBox);
      // 
      // txtStokMiktar
      // 
      this.txtStokMiktar.Location = new System.Drawing.Point(88, 8);
      this.txtStokMiktar.Name = "txtStokMiktar";
      this.txtStokMiktar.Size = new System.Drawing.Size(158, 20);
      this.txtStokMiktar.TabIndex = 0;
      this.txtStokMiktar.Enter += new System.EventHandler(this.AktifTextBox);
      this.txtStokMiktar.Leave += new System.EventHandler(this.PasifTextBox);
      // 
      // labelControl7
      // 
      this.labelControl7.Location = new System.Drawing.Point(8, 38);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(52, 13);
      this.labelControl7.TabIndex = 1;
      this.labelControl7.Text = "Min. Miktar";
      // 
      // labelControl8
      // 
      this.labelControl8.Location = new System.Drawing.Point(8, 12);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new System.Drawing.Size(53, 13);
      this.labelControl8.TabIndex = 0;
      this.labelControl8.Text = "Stok Miktar";
      // 
      // peStokResim
      // 
      this.peStokResim.Location = new System.Drawing.Point(12, 12);
      this.peStokResim.Name = "peStokResim";
      this.peStokResim.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
      this.peStokResim.Size = new System.Drawing.Size(161, 172);
      this.peStokResim.TabIndex = 2;
      // 
      // btnKaydet
      // 
      this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
      this.btnKaydet.Location = new System.Drawing.Point(344, 151);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(100, 33);
      this.btnKaydet.TabIndex = 3;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // frmStokDetay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 191);
      this.Controls.Add(this.btnKaydet);
      this.Controls.Add(this.peStokResim);
      this.Controls.Add(this.panelControl2);
      this.Controls.Add(this.panelControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmStokDetay";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Stok Detay";
      this.Load += new System.EventHandler(this.frmStokDetay_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      this.panelControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokTanim.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokMinMiktar.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStokMiktar.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.peStokResim.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.TextEdit txtStokTanim;
    private DevExpress.XtraEditors.TextEdit txtStokKodu;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.TextEdit txtStokMinMiktar;
    private DevExpress.XtraEditors.TextEdit txtStokMiktar;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.LabelControl labelControl8;
    private DevExpress.XtraEditors.PictureEdit peStokResim;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
  }
}