using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainingTracker_Backend.Model;

namespace TrainingTracker_Backend.Controllers
{
    public class TrainingDetailsController : Controller
    {
        private readonly TrainingDetailsContext _context;

        public TrainingDetailsController(TrainingDetailsContext context)
        {
            _context = context;
        }

        // GET: TrainingDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrainingDetails.ToListAsync());
        }

        // GET: TrainingDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timesheetDetailsModel = await _context.TrainingDetails
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (timesheetDetailsModel == null)
            {
                return NotFound();
            }

            return View(timesheetDetailsModel);
        }

        // GET: TrainingDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrainingDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpName,EmpId,CourseName,TrainingStartDate,TrainingEndDate,TrainingStatus")] TimesheetDetailsModel timesheetDetailsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timesheetDetailsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timesheetDetailsModel);
        }

        // GET: TrainingDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timesheetDetailsModel = await _context.TrainingDetails.FindAsync(id);
            if (timesheetDetailsModel == null)
            {
                return NotFound();
            }
            return View(timesheetDetailsModel);
        }

        // POST: TrainingDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpName,EmpId,CourseName,TrainingStartDate,TrainingEndDate,TrainingStatus")] TimesheetDetailsModel timesheetDetailsModel)
        {
            if (id != timesheetDetailsModel.EmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timesheetDetailsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimesheetDetailsModelExists(timesheetDetailsModel.EmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(timesheetDetailsModel);
        }

        // GET: TrainingDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timesheetDetailsModel = await _context.TrainingDetails
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (timesheetDetailsModel == null)
            {
                return NotFound();
            }

            return View(timesheetDetailsModel);
        }

        // POST: TrainingDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timesheetDetailsModel = await _context.TrainingDetails.FindAsync(id);
            _context.TrainingDetails.Remove(timesheetDetailsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimesheetDetailsModelExists(int id)
        {
            return _context.TrainingDetails.Any(e => e.EmpId == id);
        }
    }
}
