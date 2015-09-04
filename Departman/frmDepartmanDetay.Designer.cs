namespace Proje_BilisimERP.Departman
{
  partial class frmDepartmanDetay
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanDetay));
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.txtDepartmanTanim = new DevExpress.XtraEditors.TextEdit();
      this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.txtDepartmanTanim.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(12, 34);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(91, 13);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Departman Tanım :";
      // 
      // txtDepartmanTanim
      // 
      this.txtDepartmanTanim.Location = new System.Drawing.Point(109, 31);
      this.txtDepartmanTanim.Name = "txtDepartmanTanim";
      this.txtDepartmanTanim.Size = new System.Drawing.Size(100, 20);
      this.txtDepartmanTanim.TabIndex = 0;
      // 
      // btnKaydet
      // 
      this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
      this.btnKaydet.Location = new System.Drawing.Point(109, 66);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(100, 33);
      this.btnKaydet.TabIndex = 1;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // frmDepartmanDetay
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(227, 111);
      this.Controls.Add(this.txtDepartmanTanim);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.btnKaydet);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmDepartmanDetay";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Departman Detay";
      ((System.ComponentModel.ISupportInitialize)(this.txtDepartmanTanim.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.SimpleButton btnKaydet;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    public DevExpress.XtraEditors.TextEdit txtDepartmanTanim;
  }
}