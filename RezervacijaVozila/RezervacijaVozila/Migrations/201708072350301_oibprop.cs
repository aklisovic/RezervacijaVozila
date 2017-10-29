namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oibprop : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osoba", "OIB", c => c.String(maxLength: 13));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osoba", "OIB", c => c.String());
        }
    }
}
