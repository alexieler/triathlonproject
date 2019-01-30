namespace Triathlon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alexi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Athlete", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Athlete", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Athlete", "LastName", c => c.String());
            AlterColumn("dbo.Athlete", "FirstName", c => c.String());
        }
    }
}
