namespace RezervacijaVozila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GodinaProizvodnjeInt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vozilo", "GodinaProizvodnjeTmp", c => c.Int(nullable: false));
            Sql("Update dbo.Vozilo SET GodinaProizvodnjeTmp = YEAR(GodinaProizvodnje)");
            DropColumn("dbo.Vozilo", "GodinaProizvodnje");
            RenameColumn("dbo.Vozilo", "GodinaProizvodnjeTmp", "GodinaProizvodnje");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vozilo", "GodinaProizvodnje", c => c.DateTime(nullable: false));
        }
    }
}
