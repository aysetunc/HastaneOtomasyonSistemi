using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.Entities;

namespace Hastane.DAL
{
    public class MyContext : DbContext
    {
        public MyContext():
            base("name=HastaneCon")
        {}
        public virtual DbSet<Hasta> Hastalar { get; set; }
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Hemsire> Hemsireler { get; set; }
        public virtual DbSet<Doktor> Doktorlar { get; set; }
        public virtual DbSet<Randevu> Randevular { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
