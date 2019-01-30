namespace Triathlon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRace : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Race", "AthleteID", "dbo.Athlete");
            DropPrimaryKey("dbo.Race");
            AlterColumn("dbo.Race", "RaceID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Race", "AthleteID");
            AddForeignKey("dbo.Race", "AthleteID", "dbo.Athlete", "AthleteID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Race", "AthleteID", "dbo.Athlete");
            DropPrimaryKey("dbo.Race");
            AlterColumn("dbo.Race", "RaceID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Race", "RaceID");
            AddForeignKey("dbo.Race", "AthleteID", "dbo.Athlete", "AthleteID", cascadeDelete: true);
        }
    }
}
