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
        public FollowUpRepository(PainTrackerPTContext db) : base(db){}

        public void Create(FollowUp followUp)
        {
            this.db.Add(followUp);
            db.SaveChanges();
        }
        
        public async Task<IEnumerable<FollowUp>> SelectAll()
        {
            return await db.FollowUp.ToArrayAsync();
        }

        public async Task<FollowUp> Select(Guid followUpId)
        {
            return db.FollowUp.Find(followUpId);
        }

        public void Remove(Guid followUpId)
        {
            FollowUp followUp = db.FollowUp.Find(followUpId);
            if (followUp != null)
            {
                db.FollowUp.Remove(followUp);
                this.Save();
            } 
        }

        public void Update(FollowUp followUp)
        {
            FollowUp existingFollowUp = db.FollowUp.Find(followUp.id);
            db.FollowUp.Update(followUp);
            this.Save();
        }
    }
}
