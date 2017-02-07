namespace BandMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CanAddBand : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Albums", "Release", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Albums", "Release", c => c.DateTime(nullable: false));
        }
    }
}
