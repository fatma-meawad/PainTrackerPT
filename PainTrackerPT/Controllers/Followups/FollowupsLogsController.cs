using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Controllers.Followups
{
    public class FollowupsLogsController : Controller
    {
        private  IFollowupsLogsService _followupsLogsService;

        public FollowupsLogsController(IFollowupsLogsService followupsLogsService)
        {
            _followupsLogsService = followupsLogsService;
        }

        // GET: FollowupsLogs
        public async Task<IActionResult> Index()
        {
            return View(await _followupsLogsService.SelectAll());
        }

        // GET: FollowupsLogs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followupsLog = await _followupsLogsService.SelectById(id);
            if (followupsLog == null)
            {
                return NotFound();
            }

            return View(followupsLog);
        }

        // GET: FollowupsLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FollowupsLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,timeStamp")] FollowupsLog followupsLog)
        {
            if (ModelState.IsValid)
            {
                followupsLog.Id = Guid.NewGuid();
                _followupsLogsService.Insert(followupsLog);
                return RedirectToAction(nameof(Index));
            }
            return View(followupsLog);
        }

        // GET: FollowupsLogs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followupsLog = await _followupsLogsService.SelectById(id);
            if (followupsLog == null)
            {
                return NotFound();
            }
            return View(followupsLog);
        }

        // POST: FollowupsLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Description,timeStamp")] FollowupsLog followupsLog)
        {
            if (id != followupsLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _followupsLogsService.Update(followupsLog);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FollowupsLogExists(followupsLog.Id))
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
            return View(followupsLog);
        }

        // GET: FollowupsLogs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var followupsLog = await _followupsLogsService.SelectById(id);
            if (followupsLog == null)
            {
                return NotFound();
            }

            return View(followupsLog);
        }

        // POST: FollowupsLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _followupsLogsService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool FollowupsLogExists(Guid id)
        {
            return _followupsLogsService.Exists(id);
        }
    }
}
