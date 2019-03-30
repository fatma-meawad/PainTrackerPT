using PainTrackerPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Followups.Repository
{
    public class BaseRepository : IBaseRepository
    {
        internal PainTrackerPTContext db;

        public BaseRepository(PainTrackerPTContext db)
        {
            this.db = db;
        }

        public async Task<int> Save()
        {
            return await db.SaveChangesAsync();
        }
    }
}
