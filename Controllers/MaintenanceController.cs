using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CruisinV2.Data;
using CruisinV2.Models;
using Microsoft.AspNetCore.Authorization;

namespace CruisinV2.Controllers
{
    public class MaintenanceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Maintenance
        public async Task<IActionResult> Index()
        {
            var maintenanceList = await _context.Maintenance
                .OrderByDescending(m => m.Id) // Sort by descending Id to display the newest entry at the top
                .ToListAsync();
            return View(maintenanceList);
        }
        
        // GET: Maintenance/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        // GET: Maintenance/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View("Index", await _context.Maintenance.Where( j => j.MaintenanceQuestion.Contains(SearchPhrase)).ToListAsync());
        }

        private IActionResult View(string v, object value1, object value2)
        {
            throw new NotImplementedException();
        }

        // GET: Maintenance/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }

        // GET: Maintenance/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Maintenance/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceQuestion,MaintenanceAnswer")] Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {

                maintenance.CreatedBy = User.Identity?.Name; // Save the username of the logged-in user
                maintenance.CreatedAt = DateTime.UtcNow; // Save the current date/time
                _context.Add(maintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maintenance);
        }

        // GET: Maintenance/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenance.FindAsync(id);
            if (maintenance == null || maintenance.CreatedBy != User.Identity?.Name)
            {
                return Unauthorized();
            }
            return View(maintenance);
        }

        // POST: Maintenance/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceQuestion,MaintenanceAnswer")] Maintenance maintenance)
        {
            if (id != maintenance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceExists(maintenance.Id))
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
            return View(maintenance);
        }

        // GET: Maintenance/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenance == null || maintenance.CreatedBy != User.Identity?.Name)
            {
                return Unauthorized();
            }

            return View(maintenance);
        }

        // POST: Maintenance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maintenance = await _context.Maintenance.FindAsync(id);
            if (maintenance != null)
            {
                _context.Maintenance.Remove(maintenance);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceExists(int id)
        {
            return _context.Maintenance.Any(e => e.Id == id);
        }
    }
}
