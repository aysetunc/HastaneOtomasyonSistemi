namespace Hastane.UI.WFA.RandevuForms
{
    partial class RandevuEkleForm
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
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.gpRandevu = new System.Windows.Forms.GroupBox();
            this.flpSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.gpRandevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 7);
            this.txtAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstListe
            // 
            this.lstListe.Location = new System.Drawing.Point(12, 36);
            this.lstListe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstListe.Size = new System.Drawing.Size(220, 346);
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(337, 181);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(238, 155);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(238, 126);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(238, 97);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(238, 68);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(238, 39);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(238, 10);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(433, 181);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(241, 181);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Enabled = false;
            this.cmbKanGrubu.Location = new System.Drawing.Point(333, 152);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Enabled = false;
            this.cmbCinsiyet.Location = new System.Drawing.Point(333, 123);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Enabled = false;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(333, 94);
            // 
            // txtTCKN
            // 
            this.txtTCKN.Enabled = false;
            this.txtTCKN.Location = new System.Drawing.Point(333, 65);
            this.txtTCKN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(333, 36);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(333, 7);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(6, 24);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(176, 26);
            this.cmbBirim.TabIndex = 37;
            this.cmbBirim.SelectedIndexChanged += new System.EventHandler(this.cmbBirim_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(284, 22);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(176, 26);
            this.cmbDoktor.TabIndex = 37;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // gpRandevu
            // 
            this.gpRandevu.Controls.Add(this.flpSaatler);
            this.gpRandevu.Controls.Add(this.btnRandevuKaydet);
            this.gpRandevu.Controls.Add(this.cmbBirim);
            this.gpRandevu.Controls.Add(this.cmbDoktor);
            this.gpRandevu.Location = new System.Drawing.Point(527, 7);
            this.gpRandevu.Name = "gpRandevu";
            this.gpRandevu.Size = new System.Drawing.Size(488, 375);
            this.gpRandevu.TabIndex = 38;
            this.gpRandevu.TabStop = false;
            this.gpRandevu.Text = "Randevu";
            this.gpRandevu.Visible = false;
            // 
            // flpSaatler
            // 
            this.flpSaatler.Location = new System.Drawing.Point(7, 61);
            this.flpSaatler.Name = "flpSaatler";
            this.flpSaatler.Size = new System.Drawing.Size(453, 263);
            this.flpSaatler.TabIndex = 39;
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.Location = new System.Drawing.Point(7, 330);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(136, 40);
            this.btnRandevuKaydet.TabIndex = 38;
            this.btnRandevuKaydet.Text = "Randevuyu Kaydet";
            this.btnRandevuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuKaydet.Click += new System.EventHandler(this.btnRandevuKaydet_Click);
            // 
            // RandevuEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 408);
            this.Controls.Add(this.gpRandevu);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "RandevuEkleForm";
            this.Text = "RandevuEkleForm";
            this.Load += new System.EventHandler(this.RandevuEkleForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.txtTCKN, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.cmbKanGrubu, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.btnTemizle, 0);
            this.Controls.SetChildIndex(this.lstListe, 0);
            this.Controls.SetChildIndex(this.txtAra, 0);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.gpRandevu, 0);
            this.gpRandevu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.GroupBox gpRandevu;
        private System.Windows.Forms.Button btnRandevuKaydet;
        private System.Windows.Forms.FlowLayoutPanel flpSaatler;
    }
}