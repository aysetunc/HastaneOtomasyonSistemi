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

namespace Hastane.UI.WFA.DoktorForms
{
    public partial class DoktorListeleForm : DoktorListeleFormIntermediate
    {
        public DoktorListeleForm()
        {
            InitializeComponent();
        }
        public List<Hemsire> DoktorunHemsireleri { get; set; } = new List<Hemsire>();

        private void DoktorListeleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler))); ;
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvanlar)));
            lstListe.DataSource = new DoktorRepo().GetALL();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstListe.DataSource = MyTool.Arama<Doktor>(txtAra.Text);
        }
        Doktor seciliDoktor;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;

            seciliDoktor = lstListe.SelectedItem as Doktor;

            txtAd.Text = seciliDoktor.Ad;
            txtSoyad.Text = seciliDoktor.Soyad;
            txtTCKN.Text = seciliDoktor.TCKN;
            dtpDogumTarihi.Value = seciliDoktor.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)seciliDoktor.Cinsiyet;
            cmbKanGrubu.SelectedIndex = (int)seciliDoktor.KanGrubu;
            cmbBirim.SelectedIndex = (int)seciliDoktor.Birimi;
            cmbUnvan.SelectedIndex = (int)seciliDoktor.Unvan;
            nMaas.Value = seciliDoktor.Maas;

            DoktorunHemsireleri = seciliDoktor.Hemsireler;
            clstHemsireler.Items.Clear();
            DoktorunHemsireleri.ForEach(x => clstHemsireler.Items.Add(x));
            for (int i = 0; i < clstHemsireler.Items.Count; i++)
            {
                clstHemsireler.SetItemChecked(i, true);
            }
            var atanmayanHemsireler = new HemsireRepo().GetALL().Where(x => x.Birimi == seciliDoktor.Birimi && x.AtandiMi == false).ToList();
            atanmayanHemsireler.ForEach(x => clstHemsireler.Items.Add(x));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (seciliDoktor == null) return;
            seciliDoktor = new DoktorRepo().GetByID(seciliDoktor.ID);
            seciliDoktor.Ad = txtAd.Text;
            seciliDoktor.Soyad = txtSoyad.Text;
            seciliDoktor.TCKN = txtTCKN.Text;
            seciliDoktor.DogumTarihi = dtpDogumTarihi.Value;
            seciliDoktor.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
            seciliDoktor.KanGrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString());
            seciliDoktor.Maas = nMaas.Value;
            seciliDoktor.Birimi = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            seciliDoktor.Unvan = (Unvanlar)Enum.Parse(typeof(Unvanlar), cmbUnvan.SelectedItem.ToString());
            new DoktorRepo().Update();

            for (int i = 0; i < clstHemsireler.Items.Count; i++)
            {
                if (clstHemsireler.GetItemCheckState(i) == CheckState.Checked)
                {
                    var seciliHemsire = clstHemsireler.Items[i] as Hemsire;
                    seciliHemsire = new HemsireRepo().GetByID(seciliHemsire.ID);
                    seciliHemsire.AtandiMi = true;
                    seciliHemsire.DoktorID = seciliDoktor.ID;
                    new HemsireRepo().Update();
                }
                else if (clstHemsireler.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    var secilmemisHemsire = clstHemsireler.Items[i] as Hemsire;
                    secilmemisHemsire = new HemsireRepo().GetByID(secilmemisHemsire.ID);
                    secilmemisHemsire.AtandiMi = false;
                    secilmemisHemsire.DoktorID = null;
                    new HemsireRepo().Update();
                }
            }
            lstListe.DataSource = new DoktorRepo().GetALL();
        }
    }
}
