using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Data.Followups.Services;

namespace PainTrackerPT.Controllers.Followups
{
    public class FollowUpsController : Controller
    {
        private readonly IBaseService<FollowUp> _followUpService;

        public FollowUpsController(IBaseService<FollowUp> followUpService)
        {
            _followUpService = followUpService;
        }

        // GET: FollowUps
        public async Task<IActionResult> Index()
        {
            return View(await _followUpService.SelectAll());
        }

        
        public async Task<IActionResult> FilteredIndex(Int64 id)
        {
            return View(await ((FollowUpService)_followUpService).SelectAllByPatientId(id));

        }

        // GET: FollowUps/Details/5
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followUp = await _followUpService.Select(id.Value);
            if (followUp == null)
            {
                return NotFound();
            }

            return View(followUp);
        }

        // GET: FollowUps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FollowUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientId,DoctorId,State,Description,DateGenerated,Id")] FollowUp followUp)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                _followUpService.Create(followUp);
           
                return RedirectToAction(nameof(FilteredIndex), routeValues: new { id = followUp.PatientId });
            }
            return View(followUp);
        }

        // GET: FollowUps/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var followUp = await _followUpService.Select(id.Value);
            
            if (followUp == null)
            {
                return NotFound();
            }
            return View(followUp);
        }

        // POST: FollowUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("PatientId,DoctorId,State,Description,DateGenerated,Id")] FollowUp followUp)
        {
            if (id != followUp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _followUpService.Update(followUp);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FollowUpExists(followUp.Id))
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
            return View(followUp);
        }

        // GET: FollowUps/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followUp = await _followUpService.Select(id.Value);
            if (followUp == null)
            {
                return NotFound();
            }

            return View(followUp);
        }

        // POST: FollowUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var followUp = await _followUpService.Select(id);
            _followUpService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool FollowUpExists(Int64 id)
        {
            return _followUpService.Exists(id);
        }
    }
}
