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
using Hastane.Entities;

namespace Hastane.UI.WFA.HemsireForms
{
    public partial class HemsireListeleForm : HemsireListeleFormIntermediate
    {
        public HemsireListeleForm()
        {
            InitializeComponent();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstListe.DataSource = MyTool.Arama<Hemsire>(txtAra.Text);
        }

        private void HemsireListeleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));
            lstListe.DataSource=new HemsireRepo().GetALL();
        }
        Hemsire seciliHemsire;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (seciliHemsire == null) return;

            seciliHemsire = new HemsireRepo().GetByID(seciliHemsire.ID);

            seciliHemsire.Ad = txtAd.Text;
            seciliHemsire.Soyad = txtSoyad.Text;
            seciliHemsire.TCKN = txtTCKN.Text;
            seciliHemsire.DogumTarihi = dtpDogumTarihi.Value;
            seciliHemsire.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
            seciliHemsire.KanGrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString());
            seciliHemsire.Maas = nMaas.Value;
            seciliHemsire.Birimi = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            new HemsireRepo().Update();
            lstListe.DataSource = new HemsireRepo().GetALL();
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            seciliHemsire = lstListe.SelectedItem as Hemsire;

            txtAd.Text = seciliHemsire.Ad;
            txtSoyad.Text = seciliHemsire.Soyad;
            txtTCKN.Text = seciliHemsire.TCKN;
            dtpDogumTarihi.Value = seciliHemsire.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliHemsire.Cinsiyet;
            cmbKanGrubu.SelectedIndex = (int)seciliHemsire.KanGrubu;
            cmbBirim.SelectedIndex = (int)seciliHemsire.Birimi;
            nMaas.Value = seciliHemsire.Maas;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekHemsire = new HemsireRepo().GetByID(seciliHemsire.ID);
            if (silinecekHemsire == null)
            {
                MessageBox.Show("Neyi sileyim?");
                return;
            }
            new HemsireRepo().Delete(silinecekHemsire);

            lstListe.DataSource = new HemsireRepo().GetALL();
        }
    }
}
