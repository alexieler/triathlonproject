namespace Triathlon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexDataModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Race", "RaceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Race", "RaceID", c => c.Int(nullable: false));
        }
    }
}
