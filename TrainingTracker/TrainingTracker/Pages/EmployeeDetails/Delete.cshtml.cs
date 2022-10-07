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
    public class DeleteModel : PageModel
    {
        private readonly TrainingTracker.Models.EmployeeDetailsContext _context;

        public DeleteModel(TrainingTracker.Models.EmployeeDetailsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeDetails = await _context.EmployeeDetails.FindAsync(id);

            if (EmployeeDetails != null)
            {
                _context.EmployeeDetails.Remove(EmployeeDetails);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
