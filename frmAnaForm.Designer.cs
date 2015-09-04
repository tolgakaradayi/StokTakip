namespace Proje_BilisimERP
{
  partial class frmAnaForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnKullaniciListe = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDepartmanListe = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCikis = new System.Windows.Forms.ToolStripMenuItem();
			this.nerdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.btnCikis,
            this.nerdeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(581, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tanımlamalarToolStripMenuItem
			// 
			this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKullaniciListe,
            this.btnDepartmanListe});
			this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
			this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
			// 
			// btnKullaniciListe
			// 
			this.btnKullaniciListe.Name = "btnKullaniciListe";
			this.btnKullaniciListe.Size = new System.Drawing.Size(160, 22);
			this.btnKullaniciListe.Text = "Kullanıcı Liste";
			this.btnKullaniciListe.Click += new System.EventHandler(this.btnKullaniciListe_Click);
			// 
			// btnDepartmanListe
			// 
			this.btnDepartmanListe.Name = "btnDepartmanListe";
			this.btnDepartmanListe.Size = new System.Drawing.Size(160, 22);
			this.btnDepartmanListe.Text = "Departman Liste";
			this.btnDepartmanListe.Click += new System.EventHandler(this.btnDepartmanListe_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(44, 20);
			this.btnCikis.Text = "Çıkış";
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// nerdeToolStripMenuItem
			// 
			this.nerdeToolStripMenuItem.Name = "nerdeToolStripMenuItem";
			this.nerdeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.nerdeToolStripMenuItem.Text = "Nerde";
			this.nerdeToolStripMenuItem.Click += new System.EventHandler(this.nerdeToolStripMenuItem_Click);
			// 
			// frmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 446);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmAnaForm";
			this.Text = "frmAnaForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem btnKullaniciListe;
    private System.Windows.Forms.ToolStripMenuItem btnCikis;
    private System.Windows.Forms.ToolStripMenuItem btnDepartmanListe;
		private System.Windows.Forms.ToolStripMenuItem nerdeToolStripMenuItem;
  }
}