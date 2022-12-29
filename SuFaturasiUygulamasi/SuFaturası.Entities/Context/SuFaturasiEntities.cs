using Microsoft.EntityFrameworkCore;
using SuFaturası.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SuFaturasi.DataAccess.Context
{
    public class SuFaturasiEntities:DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<SuFaturasi> SuFaturasilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=SuFaturasiDB;uid=sa;pwd=123;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Kullanici>()
                .HasMany(x => x.SuFaturasilar)
                .WithOne(x => x.Kullanici)
                .HasForeignKey(x => x.KullaniciID);

            base.OnModelCreating(modelBuilder);
        }

    }
}
