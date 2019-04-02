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
    public class AnswerRepository : BaseRepository<Answer>
    {
        public AnswerRepository(PainTrackerPTContext db) : base(db) { }
        public async Task<IEnumerable<Answer>> SelectAllByQuestionId(Int64 questionId)
        {
            return await _dbSet.Where(q => q.QuestionId == questionId).ToListAsync();
        }
    }
}
