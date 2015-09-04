namespace Proje_BilisimERP.cari
{
  partial class frmCariDetay
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariDetay));
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.lkpCariGrup = new DevExpress.XtraEditors.LookUpEdit();
      this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
      this.txtCariTanim = new DevExpress.XtraEditors.TextEdit();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.lkpCariGrup.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCariTanim.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(11, 16);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(49, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Cari Kodu ";
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(11, 42);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(50, 13);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Cari Tanım";
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(11, 68);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(45, 13);
      this.labelControl3.TabIndex = 2;
      this.labelControl3.Text = "Cari Grup";
      // 
      // lkpCariGrup
      // 
      this.lkpCariGrup.Location = new System.Drawing.Point(86, 64);
      this.lkpCariGrup.Name = "lkpCariGrup";
      this.lkpCariGrup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lkpCariGrup.Properties.NullText = "";
      this.lkpCariGrup.Size = new System.Drawing.Size(100, 20);
      this.lkpCariGrup.TabIndex = 3;
      // 
      // txtCariKodu
      // 
      this.txtCariKodu.Location = new System.Drawing.Point(86, 12);
      this.txtCariKodu.Name = "txtCariKodu";
      this.txtCariKodu.Size = new System.Drawing.Size(214, 20);
      this.txtCariKodu.TabIndex = 4;
      // 
      // txtCariTanim
      // 
      this.txtCariTanim.Location = new System.Drawing.Point(86, 38);
      this.txtCariTanim.Name = "txtCariTanim";
      this.txtCariTanim.Size = new System.Drawing.Size(214, 20);
      this.txtCariTanim.TabIndex = 5;
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(75, 67);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(4, 13);
      this.labelControl4.TabIndex = 8;
      this.labelControl4.Text = ":";
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(75, 41);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(4, 13);
      this.labelControl5.TabIndex = 7;
      this.labelControl5.Text = ":";
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(75, 15);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(4, 13);
      this.labelControl6.TabIndex = 6;
      this.labelControl6.Text = ":";
      // 
      // btnKaydet
      // 
      this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
      this.btnKaydet.Location = new System.Drawing.Point(86, 99);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(100, 33);
      this.btnKaydet.TabIndex = 9;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // frmCariDetay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 147);
      this.Controls.Add(this.btnKaydet);
      this.Controls.Add(this.labelControl4);
      this.Controls.Add(this.labelControl5);
      this.Controls.Add(this.labelControl6);
      this.Controls.Add(this.txtCariTanim);
      this.Controls.Add(this.txtCariKodu);
      this.Controls.Add(this.lkpCariGrup);
      this.Controls.Add(this.labelControl3);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.labelControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmCariDetay";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cari Detay";
      this.Load += new System.EventHandler(this.frmCariDetay_Load);
      ((System.ComponentModel.ISupportInitialize)(this.lkpCariGrup.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCariTanim.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LookUpEdit lkpCariGrup;
    private DevExpress.XtraEditors.TextEdit txtCariKodu;
    private DevExpress.XtraEditors.TextEdit txtCariTanim;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.SimpleButton btnKaydet;
  }
}