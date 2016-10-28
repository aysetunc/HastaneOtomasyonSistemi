using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL;
using Hastane.UI.WFA.BaseForms;
using Hastane.UI.WFA.DoktorForms;
using Hastane.UI.WFA.HastaForms;
using Hastane.UI.WFA.HemsireForms;
using Hastane.UI.WFA.RandevuForms;

namespace Hastane.UI.WFA
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        //MyContext Context = new MyContext();
        HastaEkleForm frmHastaEkle;
        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaEkle == null || frmHastaEkle.IsDisposed)
                frmHastaEkle = new HastaEkleForm();
            frmHastaEkle.MdiParent = this;
            frmHastaEkle.Text = "Hasta Ekleme Formu";
            frmHastaEkle.Show();

        }
        HastaListeleForm frmHastaListele;
        private void hastaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaListele == null || frmHastaListele.IsDisposed)
                frmHastaListele = new HastaListeleForm();
            frmHastaListele.MdiParent = this;
            frmHastaListele.Text = "Hasta Listeleme Formu";
            frmHastaListele.Show();
        }
        //PersonelEkleForm frmPersonelEkle;
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmPersonelEkle == null || frmPersonelEkle.IsDisposed)
            //    frmPersonelEkle = new PersonelEkleForm();
            //frmPersonelEkle.MdiParent = this;
            //frmPersonelEkle.Text = "Personel Ekleme Formu";
            //frmPersonelEkle.Personeller = this.Context.Personeller;
            //frmPersonelEkle.Show();
        }
        HemsireEkleForm frmHemsireEkle;
        private void hemşireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireEkle == null || frmHemsireEkle.IsDisposed)
                frmHemsireEkle = new HemsireEkleForm();
            frmHemsireEkle.MdiParent = this;
            frmHemsireEkle.Text = "Hemsire Ekleme Formu";
            frmHemsireEkle.Show();
        }
        HemsireListeleForm frmHemsireListele;
        private void hemşireListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireListele == null || frmHemsireListele.IsDisposed)
                frmHemsireListele = new HemsireListeleForm();
            frmHemsireListele.MdiParent = this;
            frmHemsireListele.Text = "Hemsireler Listeleme Formu";
            frmHemsireListele.Show();
        }
        DoktorEkleForm frmDoktorEkle;
        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorEkle == null || frmDoktorEkle.IsDisposed)
                frmDoktorEkle = new DoktorEkleForm();
            frmDoktorEkle.MdiParent = this;
            frmDoktorEkle.Text = "Doktor Ekleme Formu";
            frmDoktorEkle.Show();
        }
        DoktorListeleForm frmDoktorListele;
        private void doktorListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorListele == null || frmDoktorListele.IsDisposed)
                frmDoktorListele = new DoktorListeleForm();
            frmDoktorListele.MdiParent = this;
            frmDoktorListele.Text = "Doktor Ekleme Formu";
            frmDoktorListele.Show();
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    MyTool.JSon<MyContext>(Context, new SaveFileDialog());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    MyTool.JSon<MyContext>(ref Context, new OpenFileDialog());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        RandevuEkleForm frmRandevuEkle;
        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevuEkle == null || frmRandevuEkle.IsDisposed)
                frmRandevuEkle = new RandevuEkleForm();
            frmRandevuEkle.MdiParent = this;
            frmRandevuEkle.Text = "Doktor Ekleme Formu";
            frmRandevuEkle.Show();
        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
