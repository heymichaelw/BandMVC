namespace BandMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNameToBandName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bands", "BandName", c => c.String());
            DropColumn("dbo.Bands", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bands", "Name", c => c.String());
            DropColumn("dbo.Bands", "BandName");
        }
    }
}
