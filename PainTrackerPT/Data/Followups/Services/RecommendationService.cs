
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Common.Followups;

namespace PainTrackerPT.Data.Followups
{
    public class RecommendationService : IRecommendationService
    {
        private IRecommendationRepository _recommendationRepository;

        public RecommendationService()
        {
            this._recommendationRepository = new RecommendationRepository();
        }
        
        public void CreateNewRecommendation(Recommendation recommendation)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecommendation(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Recommendation> Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recommendation>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateRecommendation(Guid id, Recommendation recommendation)
        {
            throw new NotImplementedException();
        }
    }
}
