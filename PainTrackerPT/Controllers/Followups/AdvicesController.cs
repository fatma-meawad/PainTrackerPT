using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Data.Followups.Services;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Controllers.Followups
{
    public class AdvicesController : Controller
    {
        private readonly AdviceService _adviceService;

        public AdvicesController(IBaseService<Advice> baseService)
        {
            _adviceService = (AdviceService) baseService;
        }

        // GET: Advices
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.id = id;
            return View(await ((AdviceService)_adviceService).SelectAllByAnswerId(id));
        }

        // GET: Advices/Details/5
        public async Task<IActionResult> Details(Int64 id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _adviceService.Select(id);
            if (advice == null)
            {
                return NotFound();
            }

            return View(advice);
        }

        // GET: Advices/Create
        public IActionResult Create(int id)
        {
            ViewBag.id = id;
        
            return View();
        }

        // POST: Advices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("AnswerId,Description,DateGenerated")] Advice advice)
        {
            if (ModelState.IsValid)
            {
                advice.AnswerId = id;
                _adviceService.Create(advice);
                return RedirectToAction(nameof(Index), routeValues: new { id = advice.AnswerId });
            }
            return View(advice);
        }

        // GET: Advices/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _adviceService.Select(id.Value);
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
        public async Task<IActionResult> Edit(Int64 id, [Bind("AnswerId,Description,DateGenerated,Id")] Advice advice)
        {
            if (id != advice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _adviceService.Update(advice);
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
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advice = await _adviceService.Select(id.Value);
            if (advice == null)
            {
                return NotFound();
            }

            return View(advice);
        }

        // POST: Advices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var advice = await _adviceService.Select(id);
            _adviceService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AdviceExists(Int64 id)
        {
            return _adviceService.Exists(id);
        }
    }
}
