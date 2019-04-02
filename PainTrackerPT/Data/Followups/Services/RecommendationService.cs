
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
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Data.Followups.Services;

namespace PainTrackerPT.Data.Followups
{
    public class RecommendationService : BaseService <Recommendation>
    {
        // TODO: DI THIS
        public RecommendationService(IBaseRepository <Recommendation> baseRepository) : base(baseRepository)
        {
        }
        public async Task<IEnumerable<Recommendation>> SelectAllByAnswerId(Int64 answerId)
        {
            return await ((RecommendationRepository)_baseRepository).SelectAllByAnswerId(answerId);
        }
    }
}
