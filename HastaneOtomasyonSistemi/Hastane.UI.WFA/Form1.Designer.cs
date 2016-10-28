namespace Hastane.UI.WFA
{
    partial class Form1
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
            this.idariİşlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idariİşlerToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // idariİşlerToolStripMenuItem
            // 
            this.idariİşlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.doktorToolStripMenuItem});
            this.idariİşlerToolStripMenuItem.Name = "idariİşlerToolStripMenuItem";
            this.idariİşlerToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.idariİşlerToolStripMenuItem.Text = "İdari İşler";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelListeleToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelListeleToolStripMenuItem
            // 
            this.personelListeleToolStripMenuItem.Name = "personelListeleToolStripMenuItem";
            this.personelListeleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.personelListeleToolStripMenuItem.Text = "Personel Listele";
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hemşireEkleToolStripMenuItem,
            this.hemşireListeleToolStripMenuItem});
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hemşireToolStripMenuItem.Text = "Hemşire";
            // 
            // hemşireEkleToolStripMenuItem
            // 
            this.hemşireEkleToolStripMenuItem.Name = "hemşireEkleToolStripMenuItem";
            this.hemşireEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hemşireEkleToolStripMenuItem.Text = "Hemşire Ekle";
            this.hemşireEkleToolStripMenuItem.Click += new System.EventHandler(this.hemşireEkleToolStripMenuItem_Click);
            // 
            // hemşireListeleToolStripMenuItem
            // 
            this.hemşireListeleToolStripMenuItem.Name = "hemşireListeleToolStripMenuItem";
            this.hemşireListeleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hemşireListeleToolStripMenuItem.Text = "Hemşire Listele";
            this.hemşireListeleToolStripMenuItem.Click += new System.EventHandler(this.hemşireListeleToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorEkleToolStripMenuItem,
            this.doktorListeleToolStripMenuItem});
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.doktorToolStripMenuItem.Text = "Doktor";
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.doktorEkleToolStripMenuItem.Text = "Doktor Ekle";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // doktorListeleToolStripMenuItem
            // 
            this.doktorListeleToolStripMenuItem.Name = "doktorListeleToolStripMenuItem";
            this.doktorListeleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.doktorListeleToolStripMenuItem.Text = "Doktor Listele";
            this.doktorListeleToolStripMenuItem.Click += new System.EventHandler(this.doktorListeleToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEkleToolStripMenuItem,
            this.hastaListeleToolStripMenuItem});
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.hastaToolStripMenuItem.Text = "Hasta";
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hastaEkleToolStripMenuItem.Text = "Hasta Ekle";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaEkleToolStripMenuItem_Click);
            // 
            // hastaListeleToolStripMenuItem
            // 
            this.hastaListeleToolStripMenuItem.Name = "hastaListeleToolStripMenuItem";
            this.hastaListeleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hastaListeleToolStripMenuItem.Text = "Hasta Listele";
            this.hastaListeleToolStripMenuItem.Click += new System.EventHandler(this.hastaListeleToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuEkleToolStripMenuItem,
            this.randevuListeleToolStripMenuItem});
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.randevuToolStripMenuItem.Text = "Randevu";
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // randevuEkleToolStripMenuItem
            // 
            this.randevuEkleToolStripMenuItem.Name = "randevuEkleToolStripMenuItem";
            this.randevuEkleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.randevuEkleToolStripMenuItem.Text = "Randevu Ekle";
            this.randevuEkleToolStripMenuItem.Click += new System.EventHandler(this.randevuEkleToolStripMenuItem_Click);
            // 
            // randevuListeleToolStripMenuItem
            // 
            this.randevuListeleToolStripMenuItem.Name = "randevuListeleToolStripMenuItem";
            this.randevuListeleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.randevuListeleToolStripMenuItem.Text = "Randevu Listele";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dışarıAktarToolStripMenuItem,
            this.içeriAktarToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            this.dışarıAktarToolStripMenuItem.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem_Click);
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.içeriAktarToolStripMenuItem.Text = "İçeri Aktar";
            this.içeriAktarToolStripMenuItem.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 440);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "Hastane Otomasyonu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem idariİşlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
    }
}

