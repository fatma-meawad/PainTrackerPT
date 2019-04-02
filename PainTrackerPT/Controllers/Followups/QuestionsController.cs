using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Controllers.Followups
{
    public class QuestionsController : Controller
    {
        private readonly IBaseService<Question> _questionService;

        public QuestionsController(IBaseService<Question> questionService)
        {
            _questionService = questionService;
            System.Diagnostics.Debug.WriteLine("@@@@ questionService.gettype: " + _questionService.GetType());
            
        }

        // GET: Questions
        public async Task<IActionResult> Index(int id)
        {

            System.Diagnostics.Debug.WriteLine("@@@ Indexid: " + id);
            return View(await ((QuestionService)_questionService).SelectAllByFollowUpId(id));
        }

        // GET: Questions/Details/5
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Question question = await _questionService.Select(id.Value);
            ViewBag.id = question.FollowUpId;
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // GET: Questions/Create

        public IActionResult Create(int id)
        {
            ViewBag.id = id;
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Description,DateGenerated,FollowUpId")] Question question)
        {
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("THE FK IS :" + question.FollowUpId.ToString());
                question.FollowUpId = id;
                _questionService.Create(question);
                return RedirectToAction(nameof(Index), routeValues: new { id = question.FollowUpId });
            }

            ViewBag.id = question.FollowUpId;
        
            return View(question);
        }

        // GET: Questions/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _questionService.Select(id.Value);
            ViewBag.id = question.FollowUpId;
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("Description,DateGenerated,Id")] Question question)
        {
            Question oldQns = await _questionService.Select(id);
            if (id != question.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    oldQns.DateGenerated = question.DateGenerated;
                    oldQns.Description = question.Description;
                    _questionService.Update(oldQns);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), routeValues: new { id = oldQns.FollowUpId });
            }
            return View(question);
        }

        // GET: Questions/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _questionService.Select(id.Value);
            ViewBag.id = question.FollowUpId;
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var question = await _questionService.Select(id);
            _questionService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionExists(Int64 id)
        {
            return _questionService.Exists(id);
        }
    }
}
