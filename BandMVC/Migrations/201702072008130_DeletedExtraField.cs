namespace BandMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedExtraField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bands", "Formed", c => c.String());
            DropColumn("dbo.Bands", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bands", "MyProperty", c => c.Int(nullable: false));
            AlterColumn("dbo.Bands", "Formed", c => c.DateTime(nullable: false));
        }
    }
}
