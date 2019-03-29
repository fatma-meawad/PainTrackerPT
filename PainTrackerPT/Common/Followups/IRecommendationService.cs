using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IRecommendationService
    {
        void CreateNewRecommendation(Recommendation recommendation);
        void UpdateRecommendation(Guid id, Recommendation recommendation);
        void DeleteRecommendation(Guid id);
        Task<Recommendation> Select(Guid id);
        Task<IEnumerable<Recommendation>> SelectAll();
    }
}
