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
    public class PainDiariesController : Controller
    {
        private readonly TrackingEventsContext _context;

        public PainDiariesController(TrackingEventsContext context)
        {
            _context = context;
        }

        // GET: PainDiaries
        public async Task<IActionResult> Index()
        {
            return View(await _context.PainDiary.ToListAsync());
        }

        // GET: PainDiaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var painDiary = await _context.PainDiary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (painDiary == null)
            {
                return NotFound();
            }

            return View(painDiary);
        }

        // GET: PainDiaries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PainDiaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,eventName,eventDate,painLevel")] PainDiary painDiary)
        {

            TrackingEventsAPI te = new TrackingEventsAPI();
            te.addPainDairyEvent(painDiary);

            return RedirectToAction(nameof(Index));

        }

        // GET: PainDiaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var painDiary = await _context.PainDiary.FindAsync(id);
            if (painDiary == null)
            {
                return NotFound();
            }
            return View(painDiary);
        }

        // POST: PainDiaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,eventName,eventDate,painLevel")] PainDiary painDiary)
        {
            if (id != painDiary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(painDiary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PainDiaryExists(painDiary.Id))
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
            return View(painDiary);
        }

        // GET: PainDiaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var painDiary = await _context.PainDiary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (painDiary == null)
            {
                return NotFound();
            }

            return View(painDiary);
        }

        // POST: PainDiaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var painDiary = await _context.PainDiary.FindAsync(id);
            _context.PainDiary.Remove(painDiary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PainDiaryExists(int id)
        {
            return _context.PainDiary.Any(e => e.Id == id);
        }
    }
}
