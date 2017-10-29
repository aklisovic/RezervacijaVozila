using RezervacijaVozila.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RezervacijaVozila.DAL
{
    public class VozilaContext : DbContext
    {
        public VozilaContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Marka> Marke { get; set; }
        public DbSet<Vozilo> Vozila { get; set; }
        public DbSet<Mjesto> Mjesta { get; set; }
        public DbSet<Zupanija> Zupanije { get; set; }
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }
    }
}