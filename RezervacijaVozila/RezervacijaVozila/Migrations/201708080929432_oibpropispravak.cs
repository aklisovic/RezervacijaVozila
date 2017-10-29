namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oibpropispravak : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osoba", "OIB", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osoba", "OIB", c => c.String(maxLength: 13));
        }
    }
}
