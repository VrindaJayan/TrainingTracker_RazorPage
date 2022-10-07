namespace TrainingTracker_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimesheetDetailsModel",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        CourseName = c.String(),
                        TrainingStartDate = c.DateTime(nullable: false),
                        TrainingEndDate = c.DateTime(nullable: false),
                        TrainingStatus = c.String(),
                    })
                .PrimaryKey(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimesheetDetailsModel");
        }
    }
}
