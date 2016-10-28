using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public interface IMaas
    {
        int AylikGunSayisi { get; set; }
        decimal Maas { get; set; }
        decimal BirimFiyat { get; }
        decimal MaasHesapla();
    }
}
