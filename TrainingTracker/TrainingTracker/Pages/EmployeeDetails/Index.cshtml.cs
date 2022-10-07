using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrainingTracker.Models;

namespace TrainingTracker.Pages.EmployeeDetails
{
    public class IndexModel : PageModel
    {
        private readonly TrainingTracker.Models.EmployeeDetailsContext _context;

        public IndexModel(TrainingTracker.Models.EmployeeDetailsContext context)
        {
            _context = context;
        }

        public IList<TrainingTracker.Models.EmployeeDetails> EmployeeDetails { get;set; }

        public async Task OnGetAsync()
        {
            EmployeeDetails = await _context.EmployeeDetails.ToListAsync();
        }
    }
}
