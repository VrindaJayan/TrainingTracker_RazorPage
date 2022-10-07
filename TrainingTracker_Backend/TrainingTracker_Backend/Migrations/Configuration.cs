namespace TrainingTracker_Backend.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrainingTracker_Backend.Model;
    internal sealed class Configuration : DbMigrationsConfiguration<TrainingTracker_Backend.Model.TrainingDetailsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrainingTracker_Backend.Model.TrainingDetailsContext context)
        {
            List<TimesheetDetailsModel> timesheetDetails = new List<TimesheetDetailsModel>
              {
                new TimesheetDetailsModel { CourseName = "C1",  EmpId= 000, EmpName = "AAA", TrainingEndDate=new DateTime(2022,12,12), TrainingStartDate=new DateTime(2022,11,11),TrainingStatus="Ongoing"},
                new TimesheetDetailsModel { CourseName = "C2", EmpId= 111, EmpName = "BBB", TrainingEndDate=new DateTime(2022,12,12), TrainingStartDate=new DateTime(2022,11,11),TrainingStatus="Ongoing"},
                new TimesheetDetailsModel { CourseName = "C3", EmpId= 222, EmpName = "CCC",  TrainingEndDate=new DateTime(2022,12,12), TrainingStartDate=new DateTime(2022,11,11),TrainingStatus="Ongoing"}
              };
            timesheetDetails.ForEach(s =>
            context.TrainingDetails.Add(s));
            context.SaveChanges();
        }
    }
}

