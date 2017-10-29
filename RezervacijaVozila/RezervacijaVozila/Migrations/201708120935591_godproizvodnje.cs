namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class godproizvodnje : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vozilo", "GodinaProizvodnje", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vozilo", "GodinaProizvodnje", c => c.Int(nullable: false));
        }
    }
}
