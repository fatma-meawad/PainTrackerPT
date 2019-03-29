using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups
{
    public interface IRecommendationRepository
    {
        void Create(Recommendation recommendation);
        Task<IEnumerable<Recommendation>> SelectAll();
        Task<Recommendation> SelectById(Guid id);
        void Update(Recommendation recommendation);
        void Remove(Guid id);
        Task<int> Save();
    }

    public class RecommendationRepository : IRecommendationRepository
    {
        public void Create(Recommendation recommendation)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recommendation>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Recommendation> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Recommendation recommendation)
        {
            throw new NotImplementedException();
        }
    }
}
