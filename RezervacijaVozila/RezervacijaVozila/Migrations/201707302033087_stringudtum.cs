namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringudtum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osoba", "DatumRodenja", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rezervacija", "VrijemeRezervacije", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rezervacija", "VrijemePreuzimanja", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezervacija", "VrijemePreuzimanja", c => c.String());
            AlterColumn("dbo.Rezervacija", "VrijemeRezervacije", c => c.String());
            AlterColumn("dbo.Osoba", "DatumRodenja", c => c.String());
        }
    }
}
