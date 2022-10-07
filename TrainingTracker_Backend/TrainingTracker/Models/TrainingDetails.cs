﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingTracker.Models
{
    public class TrainingDetails
    {
        public string EmpName { get; set; }

        [Key]
        public int EmpId { get; set; }

        public string CourseName { get; set; }

        public DateTime TrainingStartDate { get; set; }

        public DateTime TrainingEndDate { get; set; }

        public string TrainingStatus { get; set; }
    }
}
