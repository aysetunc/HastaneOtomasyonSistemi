using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.Entities;

namespace Hastane.BLL
{
    public class PersonelRepo : RepositoryBase<Personel, Guid> { }
    public class HastaRepo : RepositoryBase<Hasta, Guid> { }
    public class DoktorRepo : RepositoryBase<Doktor, Guid> { }
    public class HemsireRepo : RepositoryBase<Hemsire, Guid> { }
    public class RandevuRepo : RepositoryBase<Randevu, Guid> { }
}
