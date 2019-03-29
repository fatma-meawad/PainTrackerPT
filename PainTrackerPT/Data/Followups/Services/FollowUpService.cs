
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

        public void CreateNewFollowUp(FollowUp followUp)
        {
            throw new NotImplementedException();
        }

        public void DeleteFollowUp(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SelectAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateFollowUp(Guid id, FollowUp followUp)
        {
            throw new NotImplementedException();
        }
    }
}
