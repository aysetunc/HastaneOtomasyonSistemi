using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    [Table("Doktorlar")]
    public class Doktor : HastaneBC, IMaas
    {
        public int AylikGunSayisi
        {
            get; set;
        }
        public decimal BirimFiyat
        {
            get
            {
                return Maas / 30;
            }
        }
        public decimal Maas
        {
            get; set;
        }
        public decimal MaasHesapla()
        {
            return BirimFiyat * AylikGunSayisi * 1.13m;
        }
        public Birimler Birimi { get; set; }
        public Unvanlar Unvan { get; set; }
        public virtual List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public virtual List<Randevu> Randevular { get; set; } = new List<Randevu>();
    }
}
