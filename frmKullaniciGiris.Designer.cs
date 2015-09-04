namespace Proje_BilisimERP
{
  partial class frmKullaniciGiris
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
      this.txtKullaniciKodu = new System.Windows.Forms.TextBox();
      this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
      this.btnIptal = new System.Windows.Forms.Button();
      this.btnGiris = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtKullaniciKodu
      // 
      this.txtKullaniciKodu.Location = new System.Drawing.Point(325, 168);
      this.txtKullaniciKodu.MaxLength = 10;
      this.txtKullaniciKodu.Name = "txtKullaniciKodu";
      this.txtKullaniciKodu.Size = new System.Drawing.Size(156, 20);
      this.txtKullaniciKodu.TabIndex = 0;
      this.txtKullaniciKodu.Text = "1";
      // 
      // txtKullaniciSifre
      // 
      this.txtKullaniciSifre.Location = new System.Drawing.Point(325, 194);
      this.txtKullaniciSifre.MaxLength = 8;
      this.txtKullaniciSifre.Name = "txtKullaniciSifre";
      this.txtKullaniciSifre.PasswordChar = '*';
      this.txtKullaniciSifre.Size = new System.Drawing.Size(156, 20);
      this.txtKullaniciSifre.TabIndex = 1;
      this.txtKullaniciSifre.Text = "1";
      // 
      // btnIptal
      // 
      this.btnIptal.Location = new System.Drawing.Point(325, 227);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(75, 23);
      this.btnIptal.TabIndex = 3;
      this.btnIptal.Text = "İptal";
      this.btnIptal.UseVisualStyleBackColor = true;
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // btnGiris
      // 
      this.btnGiris.Location = new System.Drawing.Point(406, 227);
      this.btnGiris.Name = "btnGiris";
      this.btnGiris.Size = new System.Drawing.Size(75, 23);
      this.btnGiris.TabIndex = 2;
      this.btnGiris.Text = "Giriş";
      this.btnGiris.UseVisualStyleBackColor = true;
      this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(234, 172);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Kullanıcı Kodu";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(234, 198);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Kullanıcı Şifre";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(309, 198);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(10, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = ":";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(309, 172);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(10, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = ":";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.pictureBox1.Image = global::Proje_BilisimERP.Properties.Resources.Koala;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(228, 262);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // defaultLookAndFeel1
      // 
      this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
      // 
      // frmKullaniciGiris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(493, 262);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGiris);
      this.Controls.Add(this.btnIptal);
      this.Controls.Add(this.txtKullaniciSifre);
      this.Controls.Add(this.txtKullaniciKodu);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmKullaniciGiris";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmKullaniciGiris";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtKullaniciKodu;
    private System.Windows.Forms.TextBox txtKullaniciSifre;
    private System.Windows.Forms.Button btnIptal;
    private System.Windows.Forms.Button btnGiris;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pictureBox1;
    private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
  }
}