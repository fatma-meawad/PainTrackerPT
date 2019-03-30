using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups
{
    public class FollowUpRepository : BaseRepository
    {
        public void Create(FollowUp followUp)
        {

        }
        
        public Task<IEnumerable<FollowUp>> SelectAll()
        {

        }

        public Task<FollowUp> Select(Guid followUpId)
        {

        }

        public void Remove(Guid id)
        {

        }

        public void Update(FollowUp followUp)
        {

        }

        public Task<int> Save()
        {

        }
    }
}
