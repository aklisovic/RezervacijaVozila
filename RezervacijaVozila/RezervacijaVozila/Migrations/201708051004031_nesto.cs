namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nesto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.String());
        }
    }
}
