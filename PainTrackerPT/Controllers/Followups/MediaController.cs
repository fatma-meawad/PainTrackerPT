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
    public class MediaController : Controller
    {
        private readonly IBaseService<Media> _mediaService;

        public MediaController(IBaseService<Media> mediaService)
        {
            _mediaService = mediaService;
        }

        // GET: Media
        public async Task<IActionResult> Index(int id)
        {
            return View(await ((MediaService)_mediaService).SelectAllByAnswerId(id));

        }

        // GET: Media/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _mediaService.Select(id.Value);
            if (media == null)
            {
                return NotFound();
            }

            return View(media);
        }

        // GET: Media/Create
        public IActionResult Create(int id)
        {
            ViewBag.id = id;

            return View();
        }

        // POST: Media/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("AnswerId,MediaUrl,Id")] Media media)
        {
            if (ModelState.IsValid)
            {
                media.AnswerId = id;
                _mediaService.Create(media);
                return RedirectToAction(nameof(Index));
            }
            return View(media);
        }

        // GET: Media/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _mediaService.Select(id.Value);
            if (media == null)
            {
                return NotFound();
            }
            return View(media);
        }

        // POST: Media/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("AnswerId,MediaUrl,Id")] Media media)
        {
            if (id != media.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _mediaService.Update(media);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MediaExists(media.Id))
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
            return View(media);
        }

        // GET: Media/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var media = await _mediaService.Select(id.Value);
            if (media == null)
            {
                return NotFound();
            }

            return View(media);
        }

        // POST: Media/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var media = await _mediaService.Select(id);
            _mediaService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool MediaExists(Int64 id)
        {
            return _mediaService.Exists(id);
        }
    }
}
