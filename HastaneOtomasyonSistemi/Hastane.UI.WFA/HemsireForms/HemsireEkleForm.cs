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
using Hastane.UI.WFA.BaseForms;

namespace Hastane.UI.WFA.HemsireForms
{
    public partial class HemsireEkleForm : EkleBaseForm
    {
        public HemsireEkleForm()
        {
            InitializeComponent();
        }

        private void HemsireEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new HemsireRepo().Insert(new Hemsire()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKN.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    KanGrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString()),
                    Birimi = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString()),
                    Maas = nMaas.Value
                });
                MyTool.FormTemizle(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
