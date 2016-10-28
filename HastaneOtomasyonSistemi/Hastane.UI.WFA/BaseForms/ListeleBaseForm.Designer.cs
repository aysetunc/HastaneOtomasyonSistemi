namespace Hastane.UI.WFA.BaseForms
{
    partial class ListeleBaseForm<T>
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(238, 160);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(238, 131);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(238, 102);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(238, 73);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(238, 44);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(238, 15);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(433, 186);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(241, 186);
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Location = new System.Drawing.Point(333, 157);
            this.cmbKanGrubu.Size = new System.Drawing.Size(178, 26);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(333, 128);
            this.cmbCinsiyet.Size = new System.Drawing.Size(178, 26);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(333, 99);
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(333, 70);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(333, 41);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(333, 12);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(220, 23);
            this.txtAra.TabIndex = 34;
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 18;
            this.lstListe.Location = new System.Drawing.Point(12, 41);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(220, 256);
            this.lstListe.TabIndex = 35;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(337, 186);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 40);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // ListeleBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 319);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstListe);
            this.Name = "ListeleBaseForm";
            this.Text = "ListeleBaseForm";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAra;
        public System.Windows.Forms.ListBox lstListe;
        public System.Windows.Forms.Button btnSil;
    }
}