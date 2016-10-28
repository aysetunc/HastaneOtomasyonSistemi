using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    [Table("Randevular")]
    public class Randevu
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime RandevuAlmaZamani { get; set; } = DateTime.Now;
        public int SiraNumarasi { get; set; }
        public Birimler Birim { get; set; }
        public Guid HastaID { get; set; }
        public Guid DoktorID { get; set; }
        [ForeignKey("HastaID")]
        public virtual Hasta Hasta { get; set; }
        [ForeignKey("DoktorID")]
        public virtual Doktor Doktor { get; set; }
        
    }
}
