namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UklanjanjePluralizacije : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Markas", newName: "Marka");
            RenameTable(name: "dbo.Mjestoes", newName: "Mjesto");
            RenameTable(name: "dbo.Zupanijas", newName: "Zupanija");
            RenameTable(name: "dbo.Osobas", newName: "Osoba");
            RenameTable(name: "dbo.Rezervacijas", newName: "Rezervacija");
            RenameTable(name: "dbo.Voziloes", newName: "Vozilo");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Vozilo", newName: "Voziloes");
            RenameTable(name: "dbo.Rezervacija", newName: "Rezervacijas");
            RenameTable(name: "dbo.Osoba", newName: "Osobas");
            RenameTable(name: "dbo.Zupanija", newName: "Zupanijas");
            RenameTable(name: "dbo.Mjesto", newName: "Mjestoes");
            RenameTable(name: "dbo.Marka", newName: "Markas");
        }
    }
}
