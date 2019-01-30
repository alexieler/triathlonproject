namespace Triathlon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athlete",
                c => new
                    {
                        AthleteID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        Email = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        RaceType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AthleteID);
            
            CreateTable(
                "dbo.Workout",
                c => new
                    {
                        WorkoutID = c.Int(nullable: false),
                        AthleteID = c.Int(nullable: false),
                        WorkoutDescription = c.String(),
                        WorkoutDate = c.DateTime(nullable: false),
                        WorkoutDistance = c.Single(nullable: false),
                        WorkoutIntensity = c.Int(nullable: false),
                        WorkoutCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkoutID)
                .ForeignKey("dbo.Athlete", t => t.AthleteID, cascadeDelete: true)
                .Index(t => t.AthleteID);
            
            CreateTable(
                "dbo.Race",
                c => new
                    {
                        RaceID = c.Int(nullable: false, identity: true),
                        AthleteID = c.Int(nullable: false),
                        RaceType = c.Int(nullable: false),
                        TriathlonLevel = c.Int(nullable: false),
                        GoalTime = c.String(),
                        StartTrainingDate = c.DateTime(nullable: false),
                        RaceDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RaceID)
                .ForeignKey("dbo.Athlete", t => t.AthleteID, cascadeDelete: true)
                .Index(t => t.AthleteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Race", "AthleteID", "dbo.Athlete");
            DropForeignKey("dbo.Workout", "AthleteID", "dbo.Athlete");
            DropIndex("dbo.Race", new[] { "AthleteID" });
            DropIndex("dbo.Workout", new[] { "AthleteID" });
            DropTable("dbo.Race");
            DropTable("dbo.Workout");
            DropTable("dbo.Athlete");
        }
    }
}
