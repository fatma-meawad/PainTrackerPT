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
    public class RecommendationRepository : BaseRepository
    {
        DbSet<Recommendation> recommendationsSet;

        public RecommendationRepository(PainTrackerPTContext db) : base(db)
        {
            recommendationsSet = db.Set<Recommendation>();
        }

        public void Create(Recommendation recommendation)
        {
            recommendationsSet = db.Set<Recommendation>();
        }

        public void Remove(Guid id)
        {
            Recommendation recommendation = recommendationsSet.Find(id);
            if (recommendation != null)
            {
                recommendationsSet.Remove(recommendation);
                this.Save();
            }
        }

        public async Task<IEnumerable<Recommendation>> SelectAll()
        {
            return await recommendationsSet.ToArrayAsync();
        }

        public async Task<Recommendation> Select(Guid id)
        {
            return recommendationsSet.Find(id);
        }

        public void Update(Recommendation recommendation)
        {
            Recommendation existingRecommendation = recommendationsSet.Find(recommendation.Id);
            recommendationsSet.Update(recommendation);
            this.Save();
        }
    }
}
