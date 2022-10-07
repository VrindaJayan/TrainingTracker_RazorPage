using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingTracker.Models;

namespace TrainingTracker.Pages.EmployeeDetails
{
    public class CreateModel : PageModel
    {
        private readonly TrainingTracker.Models.EmployeeDetailsContext _context;

        public CreateModel(TrainingTracker.Models.EmployeeDetailsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TrainingTracker.Models.EmployeeDetails EmployeeDetails { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EmployeeDetails.Add(EmployeeDetails);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
