using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups
{
    public class QuestionRepository : BaseRepository
    {
        DbSet<Question> questionsSet;

        public QuestionRepository(PainTrackerPTContext db) : base(db)
        {
            questionsSet = db.Set<Question>();
        }

        public void Create(Question question)
        {
            this.questionsSet.Add(question);
            db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Question question = questionsSet.Find(id);
            if (question != null)
            {
                questionsSet.Remove(question);
                this.Save();
            }
        }

        public async Task<IEnumerable<Question>> SelectAll()
        {
            return await questionsSet.ToArrayAsync();
        }

        public async Task<Question> Select(Guid id)
        {
            return questionsSet.Find(id);
        }

        public void Update(Question question)
        {
            Question existingQuestion = questionsSet.Find(question.Id);
            questionsSet.Update(question);
            this.Save();
        }
    }
}
