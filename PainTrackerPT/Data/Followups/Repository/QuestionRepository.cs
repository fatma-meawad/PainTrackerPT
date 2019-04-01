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

namespace PainTrackerPT.Data.Followups.Repository
{
    public class QuestionRepository : BaseRepository<Question>
    {
        public QuestionRepository(PainTrackerPTContext db) : base(db) { }

        /**
         * Function to retrieve all Questions by Follow Up ID
         */
        public async Task<IEnumerable<Question>> SelectAllByFollowUpId(Int64 followUpId)
        {
            return await _dbSet.Where(q => q.FollowUpId == followUpId).ToListAsync();
        }
    }


}
