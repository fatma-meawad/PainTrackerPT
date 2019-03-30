using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Controllers.Followups
{
    public class AdvicesController : Controller
    {
        private readonly PainTrackerPTContext _context;

        public AdvicesController(PainTrackerPTContext context)
        {
            _context = context;
        }

        // GET: Advices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Advice.ToListAsync());
        }

        // GET: Advices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _context.Advice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advice == null)
            {
                return NotFound();
            }

            return View(advice);
        }

        // GET: Advices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Advices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnswerId,Description,DateGenerated,Id")] Advice advice)
        {
            if (ModelState.IsValid)
            {
                advice.Id = Guid.NewGuid();
                _context.Add(advice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advice);
        }

        // GET: Advices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _context.Advice.FindAsync(id);
            if (advice == null)
            {
                return NotFound();
            }
            return View(advice);
        }

        // POST: Advices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("AnswerId,Description,DateGenerated,Id")] Advice advice)
        {
            if (id != advice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdviceExists(advice.Id))
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
            return View(advice);
        }

        // GET: Advices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _context.Advice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advice == null)
            {
                return NotFound();
            }

            return View(advice);
        }

        // POST: Advices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var advice = await _context.Advice.FindAsync(id);
            _context.Advice.Remove(advice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdviceExists(Guid id)
        {
            return _context.Advice.Any(e => e.Id == id);
        }
    }
}
