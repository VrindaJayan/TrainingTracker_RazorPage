using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrainingTracker_Backend.Model
{
    public class TrainingDetailsContext : DbContext
    {
        public TrainingDetailsContext (DbContextOptions<TrainingDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<TrainingTracker_Backend.Model.TimesheetDetailsModel> TrainingDetails { get; set; }
    }
}
