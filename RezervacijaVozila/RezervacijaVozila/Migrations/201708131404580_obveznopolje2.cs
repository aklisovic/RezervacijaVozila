namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class obveznopolje2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mjesto", "SifraOpcine", c => c.String(nullable: false));
            AlterColumn("dbo.Zupanija", "PostanskiBroj", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Rezervacija", "AdresaPreuzimanja", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezervacija", "AdresaPreuzimanja", c => c.String());
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.String(maxLength: 3));
            AlterColumn("dbo.Zupanija", "PostanskiBroj", c => c.String(maxLength: 5));
            AlterColumn("dbo.Mjesto", "SifraOpcine", c => c.String());
        }
    }
}
