namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodavanjemjestapreuzimanja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Osoba", "BrojVozackeDozvole", c => c.String());
            AddColumn("dbo.Rezervacija", "MjestoPreuzimanja", c => c.Int(nullable: false));
            AddColumn("dbo.Rezervacija", "Mjesto_MjestoID", c => c.Int());
            CreateIndex("dbo.Rezervacija", "Mjesto_MjestoID");
            AddForeignKey("dbo.Rezervacija", "Mjesto_MjestoID", "dbo.Mjesto", "MjestoID");
            DropColumn("dbo.Osoba", "DozvolaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Osoba", "DozvolaID", c => c.String());
            DropForeignKey("dbo.Rezervacija", "Mjesto_MjestoID", "dbo.Mjesto");
            DropIndex("dbo.Rezervacija", new[] { "Mjesto_MjestoID" });
            DropColumn("dbo.Rezervacija", "Mjesto_MjestoID");
            DropColumn("dbo.Rezervacija", "MjestoPreuzimanja");
            DropColumn("dbo.Osoba", "BrojVozackeDozvole");
        }
    }
}
