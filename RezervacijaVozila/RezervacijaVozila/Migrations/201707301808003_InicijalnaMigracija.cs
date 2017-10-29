namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicijalnaMigracija : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markas",
                c => new
                    {
                        MarkaID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.MarkaID);
            
            CreateTable(
                "dbo.Mjestoes",
                c => new
                    {
                        MjestoID = c.Int(nullable: false, identity: true),
                        TipMjesta = c.String(),
                        SifraOpcine = c.String(),
                        Naziv = c.String(),
                        ZupanijaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MjestoID)
                .ForeignKey("dbo.Zupanijas", t => t.ZupanijaID, cascadeDelete: true)
                .Index(t => t.ZupanijaID);
            
            CreateTable(
                "dbo.Zupanijas",
                c => new
                    {
                        ZupanijaID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        PostanskiBroj = c.String(),
                        PozivniBroj = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZupanijaID);
            
            CreateTable(
                "dbo.Osobas",
                c => new
                    {
                        OsobaID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        OIB = c.String(),
                        DozvolaID = c.String(),
                        DatumRodenja = c.String(),
                        Adresa = c.String(),
                        MjestoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OsobaID)
                .ForeignKey("dbo.Mjestoes", t => t.MjestoID, cascadeDelete: true)
                .Index(t => t.MjestoID);
            
            CreateTable(
                "dbo.Rezervacijas",
                c => new
                    {
                        RezervacijaID = c.Int(nullable: false, identity: true),
                        VrijemeRezervacije = c.String(),
                        OsobaID = c.Int(nullable: false),
                        VoziloID = c.Int(nullable: false),
                        BrojPredenihKm = c.Int(nullable: false),
                        VrijemePreuzimanja = c.String(),
                    })
                .PrimaryKey(t => t.RezervacijaID)
                .ForeignKey("dbo.Osobas", t => t.OsobaID, cascadeDelete: true)
                .ForeignKey("dbo.Voziloes", t => t.VoziloID, cascadeDelete: true)
                .Index(t => t.OsobaID)
                .Index(t => t.VoziloID);
            
            CreateTable(
                "dbo.Voziloes",
                c => new
                    {
                        VoziloID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        GodinaProizvodnje = c.Int(nullable: false),
                        Registracija = c.String(),
                        BrojSjedecihMjesta = c.Int(nullable: false),
                        MarkaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VoziloID)
                .ForeignKey("dbo.Markas", t => t.MarkaID, cascadeDelete: true)
                .Index(t => t.MarkaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervacijas", "VoziloID", "dbo.Voziloes");
            DropForeignKey("dbo.Voziloes", "MarkaID", "dbo.Markas");
            DropForeignKey("dbo.Rezervacijas", "OsobaID", "dbo.Osobas");
            DropForeignKey("dbo.Osobas", "MjestoID", "dbo.Mjestoes");
            DropForeignKey("dbo.Mjestoes", "ZupanijaID", "dbo.Zupanijas");
            DropIndex("dbo.Voziloes", new[] { "MarkaID" });
            DropIndex("dbo.Rezervacijas", new[] { "VoziloID" });
            DropIndex("dbo.Rezervacijas", new[] { "OsobaID" });
            DropIndex("dbo.Osobas", new[] { "MjestoID" });
            DropIndex("dbo.Mjestoes", new[] { "ZupanijaID" });
            DropTable("dbo.Voziloes");
            DropTable("dbo.Rezervacijas");
            DropTable("dbo.Osobas");
            DropTable("dbo.Zupanijas");
            DropTable("dbo.Mjestoes");
            DropTable("dbo.Markas");
        }
    }
}
