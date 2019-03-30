using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Data.Followups.Repository;

namespace PainTrackerPT.Data.Followups
{
    public class AnswerRepository : BaseRepository
    {
        DbSet<Answer> AnswerSet;

        public AnswerRepository(PainTrackerPTContext db) : base(db)
        {
            AnswerSet = db.Set<Answer>();
        }


        public void Create(Answer answer)
        {
            this.AnswerSet.Add(answer);
            db.SaveChanges();
        }

        public void Remove(Guid id)
        {

            Answer answer = AnswerSet.Find(id);
            if (answer != null)
            {
                AnswerSet.Remove(answer);
                this.Save();
            }
        }

        public async Task<IEnumerable<Answer>> SelectAll()
        {
            return await AnswerSet.ToArrayAsync();

        }

        public async Task<Answer> Select(Guid id)
        {
            return AnswerSet.Find(id);
        }

        public void Update(Answer answer)
        {
            Answer ExistingAnswer = AnswerSet.Find(answer.id);
            AnswerSet.Update(answer);
            this.Save();
        }
    }
}
