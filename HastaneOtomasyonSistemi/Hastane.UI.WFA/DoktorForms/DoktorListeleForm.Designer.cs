namespace Hastane.UI.WFA.DoktorForms
{
    partial class DoktorListeleForm
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
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nMaas = new System.Windows.Forms.NumericUpDown();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clstHemsireler = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstListe
            // 
            this.lstListe.Size = new System.Drawing.Size(220, 274);
            this.lstListe.SelectedIndexChanged += new System.EventHandler(this.lstListe_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(337, 283);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(433, 283);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(241, 283);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(333, 246);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(178, 26);
            this.cmbUnvan.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Ünvan";
            // 
            // nMaas
            // 
            this.nMaas.DecimalPlaces = 2;
            this.nMaas.Location = new System.Drawing.Point(333, 217);
            this.nMaas.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nMaas.Name = "nMaas";
            this.nMaas.Size = new System.Drawing.Size(178, 23);
            this.nMaas.TabIndex = 41;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(333, 188);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(178, 26);
            this.cmbBirim.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Maaş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Birim";
            // 
            // clstHemsireler
            // 
            this.clstHemsireler.FormattingEnabled = true;
            this.clstHemsireler.Location = new System.Drawing.Point(517, 15);
            this.clstHemsireler.Name = "clstHemsireler";
            this.clstHemsireler.Size = new System.Drawing.Size(210, 310);
            this.clstHemsireler.TabIndex = 46;
            // 
            // DoktorListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 348);
            this.Controls.Add(this.clstHemsireler);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nMaas);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "DoktorListeleForm";
            this.Text = "DoktorListeleForm";
            this.Load += new System.EventHandler(this.DoktorListeleForm_Load);
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
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbBirim, 0);
            this.Controls.SetChildIndex(this.nMaas, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbUnvan, 0);
            this.Controls.SetChildIndex(this.clstHemsireler, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nMaas;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clstHemsireler;
    }
}