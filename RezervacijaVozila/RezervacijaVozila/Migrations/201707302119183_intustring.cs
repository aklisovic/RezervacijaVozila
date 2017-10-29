namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intustring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.Int(nullable: false));
        }
    }
}
