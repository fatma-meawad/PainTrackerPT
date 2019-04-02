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
    public class AnswersController : Controller
    {
        private readonly IBaseService<Answer> _answerService;

        public AnswersController(IBaseService<Answer> answerService)
        {
            _answerService = answerService;
        }

        // GET: Answers
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.Id = id;
            return View(await ((AnswerService)_answerService).SelectAllByFollowUpId(id));
        }

        // GET: Answers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _answerService.Select(id.Value);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // GET: Answers/Create
        public IActionResult Create(int id)
        {
            ViewBag.id = id;
            return View();
        }


        // POST: Answers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Description,DateGenerated")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.QuestionId = id;
                _answerService.Create(answer);
                return RedirectToAction(nameof(Index), routeValues: new { id = answer.QuestionId });
            }
            return View(answer);
        }

        // GET: Answers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Id = id;
            var answer = await _answerService.Select(id.Value);
            if (answer == null)
            {
                return NotFound();
            }
            return View(answer);
        }

        // POST: Answers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description, Id")] Answer answer)
        {
            Answer oldAnswer = await _answerService.Select(id);
            if (id != answer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    oldAnswer.Description = answer.Description;
                    _answerService.Update(oldAnswer);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerExist(answer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = oldAnswer.QuestionId });
            }
            return View(answer);
        }

        // GET: Answers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _answerService.Select(id.Value);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // POST: Answers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var answer = await _answerService.Select(id);
            _answerService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerExist(Int64 id)
        {
            return _answerService.Exists(id);
        }
    }
}
