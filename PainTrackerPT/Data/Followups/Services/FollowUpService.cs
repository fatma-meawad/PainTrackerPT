
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
using PainTrackerPT.Data.Followups.Repository;

namespace PainTrackerPT.Data.Followups
{
    public class FollowUpService : BaseService <FollowUp>, IFollowUpService
    {
        public FollowUpService(IBaseRepository<FollowUp> fup): base(fup) {
        }

        public void CreateNewFollowUp(FollowUp followUp)
        {
            this.Create(followUp);
        }

        public void DeleteFollowUp(Guid id)
        {
            this.Delete(id);
        }

        public void UpdateFollowUp(FollowUp followUp)
        {
            this.Update(followUp);
        }
    }
}
