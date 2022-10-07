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
    public class DetailsModel : PageModel
    {
        private readonly TrainingTracker.Models.EmployeeDetailsContext _context;

        public DetailsModel(TrainingTracker.Models.EmployeeDetailsContext context)
        {
            _context = context;
        }

        public TrainingTracker.Models.EmployeeDetails EmployeeDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeDetails = await _context.EmployeeDetails.FirstOrDefaultAsync(m => m.ID == id);

            if (EmployeeDetails == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
