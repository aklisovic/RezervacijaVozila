namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class obveznopolje1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Marka", "Naziv", c => c.String(nullable: false));
            AlterColumn("dbo.Mjesto", "Naziv", c => c.String(nullable: false));
            AlterColumn("dbo.Zupanija", "Naziv", c => c.String(nullable: false));
            AlterColumn("dbo.Osoba", "Ime", c => c.String(nullable: false));
            AlterColumn("dbo.Osoba", "Prezime", c => c.String(nullable: false));
            AlterColumn("dbo.Osoba", "OIB", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Osoba", "BrojVozackeDozvole", c => c.String(nullable: false));
            AlterColumn("dbo.Osoba", "Adresa", c => c.String(nullable: false));
            AlterColumn("dbo.Vozilo", "Naziv", c => c.String(nullable: false));
            AlterColumn("dbo.Vozilo", "Registracija", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vozilo", "Registracija", c => c.String());
            AlterColumn("dbo.Vozilo", "Naziv", c => c.String());
            AlterColumn("dbo.Osoba", "Adresa", c => c.String());
            AlterColumn("dbo.Osoba", "BrojVozackeDozvole", c => c.String());
            AlterColumn("dbo.Osoba", "OIB", c => c.String(maxLength: 11));
            AlterColumn("dbo.Osoba", "Prezime", c => c.String());
            AlterColumn("dbo.Osoba", "Ime", c => c.String());
            AlterColumn("dbo.Zupanija", "Naziv", c => c.String());
            AlterColumn("dbo.Mjesto", "Naziv", c => c.String());
            AlterColumn("dbo.Marka", "Naziv", c => c.String());
        }
    }
}
