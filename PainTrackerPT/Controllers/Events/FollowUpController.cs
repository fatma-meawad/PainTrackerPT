using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrackingEvents.Models;

namespace TrackingEvents.Controllers
{
    public class FollowupsController : Controller
    {
        private readonly TrackingEventsContext _context;

        public FollowupsController(TrackingEventsContext context)
        {
            _context = context;
        }

        // GET: Followups
        public async Task<IActionResult> Index()
        {
            return View(await _context.Followup.ToListAsync());
        }

        // GET: Followups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followup = await _context.Followup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (followup == null)
            {
                return NotFound();
            }

            return View(followup);
        }

        // GET: Followups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Followups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,followupTitle,dateGenerated,followupType")] Followup followup)
        {
            TrackingEventsAPI te = new TrackingEventsAPI();
            te.addFollowUpEvent(followup);

            return RedirectToAction(nameof(Index));
        }

        // GET: Followups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followup = await _context.Followup.FindAsync(id);
            if (followup == null)
            {
                return NotFound();
            }
            return View(followup);
        }

        // POST: Followups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,followupTitle,dateGenerated,followupType")] Followup followup)
        {
            if (id != followup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(followup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FollowupExists(followup.Id))
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
            return View(followup);
        }

        // GET: Followups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followup = await _context.Followup
                .FirstOrDefaultAsync(m => m.Id == id);
            if (followup == null)
            {
                return NotFound();
            }

            return View(followup);
        }

        // POST: Followups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var followup = await _context.Followup.FindAsync(id);
            _context.Followup.Remove(followup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FollowupExists(int id)
        {
            return _context.Followup.Any(e => e.Id == id);
        }
    }
}
