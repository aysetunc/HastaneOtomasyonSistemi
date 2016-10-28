using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    [Table("Hastalar")]
    public class Hasta : HastaneBC
    {

        public virtual List<Randevu> Randevular { get; set; } = new List<Randevu>();
    }
}
