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
    public interface IAdviceRepository
    {
        void Create(Advice advice);
        Task<IEnumerable<Advice>> SelectAll();
        Task<Advice> SelectById(Guid id);
        void Update(Advice advice);
        void Remove(Guid id);
        Task<int> Save();
    }

    public class AdviceRepository : IAdviceRepository
    {
        public void Create(Advice advice)
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

        public Task<IEnumerable<Advice>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Advice> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Advice advice)
        {
            throw new NotImplementedException();
        }
    }
}
