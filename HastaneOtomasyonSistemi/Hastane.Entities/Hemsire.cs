using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    [Table("Hemsireler")]
    public class Hemsire : HastaneBC, IMaas
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
            return BirimFiyat * AylikGunSayisi * 1.11m;
        }
        public Birimler Birimi { get; set; }
        public bool AtandiMi { get; set; } = false;
        public Guid? DoktorID { get; set; }

        [ForeignKey("DoktorID")]
        public virtual Doktor Doktoru { get; set; }
        public override string ToString() => $"{base.ToString()} - {Birimi}";
    }
}
