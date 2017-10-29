namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RezervavcijaMjestoID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mjesto", "ZupanijaID", "dbo.Zupanija");
            DropForeignKey("dbo.Osoba", "MjestoID", "dbo.Mjesto");
            DropForeignKey("dbo.Rezervacija", "OsobaID", "dbo.Osoba");
            DropForeignKey("dbo.Rezervacija", "VoziloID", "dbo.Vozilo");
            DropForeignKey("dbo.Vozilo", "MarkaID", "dbo.Marka");
            DropIndex("dbo.Rezervacija", new[] { "Mjesto_MjestoID" });
            RenameColumn(table: "dbo.Rezervacija", name: "Mjesto_MjestoID", newName: "MjestoID");
            AddColumn("dbo.Rezervacija", "AdresaPreuzimanja", c => c.String());
            AlterColumn("dbo.Rezervacija", "MjestoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Rezervacija", "MjestoID");
            AddForeignKey("dbo.Mjesto", "ZupanijaID", "dbo.Zupanija", "ZupanijaID");
            AddForeignKey("dbo.Osoba", "MjestoID", "dbo.Mjesto", "MjestoID");
            AddForeignKey("dbo.Rezervacija", "OsobaID", "dbo.Osoba", "OsobaID");
            AddForeignKey("dbo.Rezervacija", "VoziloID", "dbo.Vozilo", "VoziloID");
            AddForeignKey("dbo.Vozilo", "MarkaID", "dbo.Marka", "MarkaID");
            DropColumn("dbo.Rezervacija", "MjestoPreuzimanja");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rezervacija", "MjestoPreuzimanja", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vozilo", "MarkaID", "dbo.Marka");
            DropForeignKey("dbo.Rezervacija", "VoziloID", "dbo.Vozilo");
            DropForeignKey("dbo.Rezervacija", "OsobaID", "dbo.Osoba");
            DropForeignKey("dbo.Osoba", "MjestoID", "dbo.Mjesto");
            DropForeignKey("dbo.Mjesto", "ZupanijaID", "dbo.Zupanija");
            DropIndex("dbo.Rezervacija", new[] { "MjestoID" });
            AlterColumn("dbo.Rezervacija", "MjestoID", c => c.Int());
            DropColumn("dbo.Rezervacija", "AdresaPreuzimanja");
            RenameColumn(table: "dbo.Rezervacija", name: "MjestoID", newName: "Mjesto_MjestoID");
            CreateIndex("dbo.Rezervacija", "Mjesto_MjestoID");
            AddForeignKey("dbo.Vozilo", "MarkaID", "dbo.Marka", "MarkaID", cascadeDelete: true);
            AddForeignKey("dbo.Rezervacija", "VoziloID", "dbo.Vozilo", "VoziloID", cascadeDelete: true);
            AddForeignKey("dbo.Rezervacija", "OsobaID", "dbo.Osoba", "OsobaID", cascadeDelete: true);
            AddForeignKey("dbo.Osoba", "MjestoID", "dbo.Mjesto", "MjestoID", cascadeDelete: true);
            AddForeignKey("dbo.Mjesto", "ZupanijaID", "dbo.Zupanija", "ZupanijaID", cascadeDelete: true);
        }
    }
}
