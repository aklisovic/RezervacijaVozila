namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nesto2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zupanija", "PozivniBroj", c => c.String(maxLength: 3));
        }
    }
}
