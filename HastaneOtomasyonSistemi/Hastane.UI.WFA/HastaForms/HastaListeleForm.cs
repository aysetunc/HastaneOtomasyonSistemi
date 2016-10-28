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

namespace Hastane.UI.WFA.HastaForms
{
    public partial class HastaListeleForm : HastaListeleFormIntermediate
    {
        public HastaListeleForm()
        {
            InitializeComponent();
        }

        private void HastaListeleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            lstListe.DataSource = new HastaRepo().GetALL();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstListe.DataSource = MyTool.Arama<Hasta>(txtAra.Text);
        }
        Hasta SeciliHasta;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            SeciliHasta = lstListe.SelectedItem as Hasta;
            txtAd.Text = SeciliHasta.Ad;
            txtSoyad.Text = SeciliHasta.Soyad;
            txtTCKN.Text = SeciliHasta.TCKN;
            dtpDogumTarihi.Value = SeciliHasta.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)SeciliHasta.Cinsiyet;
            cmbKanGrubu.SelectedIndex = (int)SeciliHasta.KanGrubu;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekHasta = new HastaRepo().GetByID(SeciliHasta.ID);
            if (silinecekHasta == null)
            {
                MessageBox.Show("Neyi sileyim?");
                return;
            }
            new HastaRepo().Delete(silinecekHasta);

            lstListe.DataSource = new HastaRepo().GetALL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var guncellenecekHasta = new HastaRepo().GetByID(SeciliHasta.ID);
            if (guncellenecekHasta == null)
            {
                MessageBox.Show("Neyi güncelleyeyim?");
                return;
            }
            guncellenecekHasta.Ad = txtAd.Text;
            guncellenecekHasta.Soyad = txtSoyad.Text;
            guncellenecekHasta.DogumTarihi = dtpDogumTarihi.Value;
            guncellenecekHasta.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
            guncellenecekHasta.KanGrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString());

            new HastaRepo().Update();
            lstListe.DataSource = new HastaRepo().GetALL();
        }
    }
}
