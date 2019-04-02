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
    public class RecommendationRepository : BaseRepository<Recommendation>
    {
        public RecommendationRepository(PainTrackerPTContext db) : base(db) {}
        public async Task<IEnumerable<Recommendation>> SelectAllByAnswerId(Int64 answerId)
        {
            return await _dbSet.Where(q => q.AnswerId == answerId).ToListAsync();
        }
    }

}
