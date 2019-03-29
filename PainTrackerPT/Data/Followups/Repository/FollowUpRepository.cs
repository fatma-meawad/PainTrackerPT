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
    public interface IFollowUpRepository
    {
        void Create(FollowUp followUp);
        Task<IEnumerable<FollowUp>> SelectAll();
        Task<FollowUp> SelectById(Guid id);
        void Update(FollowUp followUp);
        void Remove(Guid id);
        Task<int> Save();
    }

    public class FollowUpRepository : IFollowUpRepository
    {
        public void Create(FollowUp followUp)
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

        public Task<IEnumerable<FollowUp>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<FollowUp> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(FollowUp followUp)
        {
            throw new NotImplementedException();
        }
    }
}
