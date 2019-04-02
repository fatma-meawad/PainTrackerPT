using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Controllers.Followups
{
    public class RecommendationsController : Controller
    {
        private readonly IBaseService<Recommendation> _recommendationService;

        public RecommendationsController(IBaseService<Recommendation> recommendationService)
        {
            _recommendationService = recommendationService;
        }

        // GET: Recommendations
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.id = id;
            return View(await ((RecommendationService)_recommendationService).SelectAllByAnswerId(id));
        }

        // GET: Recommendations/Details/5
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recommendation = await _recommendationService.Select(id.Value);
            if (recommendation == null)
            {
                return NotFound();
            }

            return View(recommendation);
        }

        // GET: Recommendations/Create
        public IActionResult Create(int id)
        {
            ViewBag.id = id;

            return View();
        }

        // POST: Recommendations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("AnswerId,Description,DateGenerated")] Recommendation recommendation)
        {
            ViewBag.id = id;
            if (ModelState.IsValid)
            {
                recommendation.AnswerId = id;
                _recommendationService.Create(recommendation);
                return RedirectToAction(nameof(Index), routeValues: new { id = recommendation.AnswerId });
            }
            return View(recommendation);
        }

        // GET: Recommendations/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recommendation = await _recommendationService.Select(id.Value);
            if (recommendation == null)
            {
                return NotFound();
            }
            return View(recommendation);
        }

        // POST: Recommendations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("AnswerId,Description,DateGenerated,Id")] Recommendation recommendation)
        {
            if (id != recommendation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _recommendationService.Update(recommendation);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecommendationExists(recommendation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), routeValues: new { id = recommendation.AnswerId });
            }
            return View(recommendation);
        }

        // GET: Recommendations/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recommendation = await _recommendationService.Select((id.Value));
            if (recommendation == null)
            {
                return NotFound();
            }

            return View(recommendation);
        }

        // POST: Recommendations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var recommendation = await _recommendationService.Select(id);
            _recommendationService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool RecommendationExists(Int64 id)
        {
            return _recommendationService.Exists(id);
        }
    }
}
