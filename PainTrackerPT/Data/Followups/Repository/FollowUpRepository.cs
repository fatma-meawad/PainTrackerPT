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
        DbSet<FollowUp> followUpsSet;

        public FollowUpRepository(PainTrackerPTContext db) : base(db){
            followUpsSet = db.Set<FollowUp>();
        }

        public void Create(FollowUp followUp)
        {
            this.followUpsSet.Add(followUp);
            db.SaveChanges();
        }
        
        public async Task<IEnumerable<FollowUp>> SelectAll()
        {
            return await followUpsSet.ToArrayAsync();
        }

        public async Task<FollowUp> Select(Guid followUpId)
        {
            return followUpsSet.Find(followUpId);
        }

        public void Remove(Guid followUpId)
        {
            FollowUp followUp = followUpsSet.Find(followUpId);
            if (followUp != null)
            {
                followUpsSet.Remove(followUp);
                this.Save();
            } 
        }

        public void Update(FollowUp followUp)
        {
            FollowUp existingFollowUp = followUpsSet.Find(followUp.Id);
            followUpsSet.Update(followUp);
            this.Save();
        }
    }
}
