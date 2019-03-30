
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
    public class AdviceService : BaseService{

        // TODO: DI This
        public AdviceService(IBaseRepository baseRepository) : base(baseRepository)
        {
        }
    
        public void CreateNewAdvice(Advice advice)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdvice(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Advice> Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Advice>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateAdvice(Guid id, Advice advice)
        {
            throw new NotImplementedException();
        }
    }
}
