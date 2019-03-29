
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
    public class AdviceService : IAdviceService{
        private IAdviceRepository _adviceRepsitory;

        public AdviceService()
        {
            this._adviceRepsitory = new AdviceRepository();
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
