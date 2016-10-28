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

namespace Hastane.UI.WFA.HastaForms
{
    public partial class HastaEkleForm : EkleBaseForm
    {
        public HastaEkleForm()
        {
            InitializeComponent();
        }


        private void HastaEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new HastaRepo().Insert(new Hasta()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTCKN.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    KanGrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString())
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
