
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
using PainTrackerPT.Data.Followups.Services;

namespace PainTrackerPT.Data.Followups
{
    public class FollowUpService : BaseService, IFollowUpService
    {
        private FollowUpRepository _followUpRepository;

        public FollowUpService(FollowUpRepository fup): base(fup) {
            this._followUpRepository = fup;
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
            return this._followUpRepository.Select(id);
        }

        public Task<IEnumerable<FollowUp>> SelectAll()
        {
            return this._followUpRepository.SelectAll();
        }

        public void UpdateFollowUp(FollowUp followUp)
        {
            this._followUpRepository.Update(followUp);
        }
    }
}
