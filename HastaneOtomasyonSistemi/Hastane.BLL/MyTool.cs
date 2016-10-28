using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.DAL;
using Hastane.Entities;
using Newtonsoft.Json;

namespace Hastane.BLL
{
    public class MyTool
    {
        public static void FormTemizle(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                    (item as TextBox).Text = string.Empty;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 0;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is CheckBox)
                    (item as CheckBox).Checked = false;
            }
        }
        public static List<T> Arama<T>(string kelime) where T : HastaneBC
        {
            kelime = kelime.ToLower();
            MyContext db = new MyContext();
            return db.Set<T>().Where(x => x.Ad.ToLower().Contains(kelime) || x.Soyad.ToLower().Contains(kelime) || x.TCKN.Contains(kelime)).ToList();
        }
        public static void JSon<T>(T context, SaveFileDialog dosyaKaydet)
        {
            dosyaKaydet.Title = "Bir JSON dosyası kaydedin";
            dosyaKaydet.Filter = "(*.json) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.Open(dosyaKaydet.FileName, FileMode.OpenOrCreate);
                    StreamWriter writer = new StreamWriter(dosya);
                    writer.Write(JsonConvert.SerializeObject(context));
                    writer.Close();
                    writer.Dispose();
                    dosya.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public static void JSon<T>(ref T context, OpenFileDialog dosyaAc)
        {
            dosyaAc.Title = "Bir JSON dosyası seçin";
            dosyaAc.Filter = "(*.json) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    dosya.Close();
                    context = JsonConvert.DeserializeObject<T>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public static List<string> SaatleriGetir()
        {
            List<string> saatListesi = new List<string>();
            for (int saat = 9; saat < 15; saat++)
            {
                if (saat == 12) saat++;
                for (int dakika = 0; dakika < 6; dakika++)
                {
                    saatListesi.Add($"{saat} : {dakika}0");
                }
            }
            return saatListesi.Take(30).ToList();
        }
    }
}
