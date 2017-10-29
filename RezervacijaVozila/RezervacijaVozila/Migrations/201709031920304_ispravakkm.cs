namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ispravakkm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rezervacija", "BrojPrijedenihKm", c => c.Int(nullable: false));
            DropColumn("dbo.Rezervacija", "BrojPredenihKm");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rezervacija", "BrojPredenihKm", c => c.Int(nullable: false));
            DropColumn("dbo.Rezervacija", "BrojPrijedenihKm");
        }
    }
}
