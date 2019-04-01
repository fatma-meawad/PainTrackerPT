using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Data.Followups.Repository;

namespace PainTrackerPT.Data.Followups
{
   

    public class AdviceRepository : BaseRepository
    {

        DbSet<Advice> AdviceSet;

        public AdviceRepository(PainTrackerPTContext db) : base(db)
        {
            AdviceSet = db.Set<Advice>();
        }
        public void Create(Advice advice)
        {
            this.AdviceSet.Add(advice);
            db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Advice advice = AdviceSet.Find(id);
            if (advice != null)
            {
                AdviceSet.Remove(advice);
                this.Save();
            }
        }


        public async Task<IEnumerable<Advice>> SelectAll()
        {
            return await AdviceSet.ToArrayAsync();
        }

        public async Task<Advice> Select(Guid id)
        {
            return AdviceSet.Find(id);
        }

        public void Update(Advice advice)
        {
            Advice ExistingAdvice = AdviceSet.Find(advice.Id);
            AdviceSet.Update(advice);
            this.Save();      
        }
    }
}
