namespace Proje_BilisimERP.kullanici
{
  partial class frmKullaniciDetay
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
      this.btnKaydet = new System.Windows.Forms.Button();
      this.txtKullaniciKodu = new System.Windows.Forms.TextBox();
      this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
      this.cmbDepartman = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lkpDepartman = new DevExpress.XtraEditors.LookUpEdit();
      this.label4 = new System.Windows.Forms.Label();
      this.ceAktif = new DevExpress.XtraEditors.CheckEdit();
      ((System.ComponentModel.ISupportInitialize)(this.lkpDepartman.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ceAktif.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // btnKaydet
      // 
      this.btnKaydet.Location = new System.Drawing.Point(110, 162);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(121, 27);
      this.btnKaydet.TabIndex = 0;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.UseVisualStyleBackColor = true;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // txtKullaniciKodu
      // 
      this.txtKullaniciKodu.Location = new System.Drawing.Point(110, 27);
      this.txtKullaniciKodu.Name = "txtKullaniciKodu";
      this.txtKullaniciKodu.Size = new System.Drawing.Size(121, 20);
      this.txtKullaniciKodu.TabIndex = 1;
      // 
      // txtKullaniciSifre
      // 
      this.txtKullaniciSifre.Location = new System.Drawing.Point(110, 53);
      this.txtKullaniciSifre.Name = "txtKullaniciSifre";
      this.txtKullaniciSifre.Size = new System.Drawing.Size(121, 20);
      this.txtKullaniciSifre.TabIndex = 2;
      // 
      // cmbDepartman
      // 
      this.cmbDepartman.FormattingEnabled = true;
      this.cmbDepartman.Location = new System.Drawing.Point(110, 79);
      this.cmbDepartman.Name = "cmbDepartman";
      this.cmbDepartman.Size = new System.Drawing.Size(121, 21);
      this.cmbDepartman.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Kullanıcı Kodu :";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Kullanıcı Şifre :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Departman";
      // 
      // lkpDepartman
      // 
      this.lkpDepartman.Location = new System.Drawing.Point(111, 107);
      this.lkpDepartman.Name = "lkpDepartman";
      this.lkpDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lkpDepartman.Properties.NullText = "seçimizini yapınız";
      this.lkpDepartman.Properties.PopupFormMinSize = new System.Drawing.Size(300, 250);
      this.lkpDepartman.Properties.PopupWidth = 500;
      this.lkpDepartman.Size = new System.Drawing.Size(120, 20);
      this.lkpDepartman.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(23, 110);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Departman";
      // 
      // ceAktif
      // 
      this.ceAktif.EditValue = true;
      this.ceAktif.Location = new System.Drawing.Point(111, 134);
      this.ceAktif.Name = "ceAktif";
      this.ceAktif.Properties.Caption = "Aktif";
      this.ceAktif.Size = new System.Drawing.Size(120, 19);
      this.ceAktif.TabIndex = 9;
      this.ceAktif.CheckedChanged += new System.EventHandler(this.ceAktif_CheckedChanged);
      // 
      // frmKullaniciDetay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(255, 225);
      this.Controls.Add(this.ceAktif);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lkpDepartman);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbDepartman);
      this.Controls.Add(this.txtKullaniciSifre);
      this.Controls.Add(this.txtKullaniciKodu);
      this.Controls.Add(this.btnKaydet);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmKullaniciDetay";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Kullanıcı Detay";
      this.Load += new System.EventHandler(this.frmKullaniciDetay_Load);
      ((System.ComponentModel.ISupportInitialize)(this.lkpDepartman.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ceAktif.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.TextBox txtKullaniciKodu;
    private System.Windows.Forms.TextBox txtKullaniciSifre;
    private System.Windows.Forms.ComboBox cmbDepartman;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private DevExpress.XtraEditors.LookUpEdit lkpDepartman;
    private System.Windows.Forms.Label label4;
    private DevExpress.XtraEditors.CheckEdit ceAktif;
  }
}