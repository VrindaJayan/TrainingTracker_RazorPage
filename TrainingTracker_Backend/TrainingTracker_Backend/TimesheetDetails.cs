using System;

namespace TrainingTracker_Backend
{
    public class TimesheetDetails
    {

        public string EmpName { get; set; }

        public int EmpId { get; set; }

        public string CourseName { get; set; }

        public DateTime TrainingStartDate { get; set; }

        public DateTime TrainingEndDate { get; set; }

        public string TrainingStatus { get; set; }

    }
}
