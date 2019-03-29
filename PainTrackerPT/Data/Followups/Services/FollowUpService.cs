
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
    public class FollowUpService : IFollowUpService {
        private IFollowUpRepository _followUpRepository;

        public FollowUpService()
        {
            this._followUpRepository = new FollowUpRepository();
        }

        public void CreateNewFollowUp(FollowUp followUp)
        {
            this._followUpRepository.Create(followUp);
        }

        public void DeleteFollowUp(Guid id)
        {
            this._followUpRepository.Remove(id);
        }

        public Task<FollowUp> Select(Guid id)
        {
            return this._followUpRepository.SelectById(id);
        }

        public Task<IEnumerable<FollowUp>> SelectAll()
        {
            return this._followUpRepository.SelectAll();
        }

        public void UpdateFollowUp(Guid id, FollowUp followUp)
        {
            this._followUpRepository.Update(followUp);
        }
    }
}
