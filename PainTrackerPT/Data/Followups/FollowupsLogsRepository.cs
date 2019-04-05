using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups
{
    public class FollowupsLogsRepository : IFollowupsLogsRepository
    {
        private readonly PainTrackerPTContext _context;
        private DbSet<FollowupsLog> _dbSet;

        public FollowupsLogsRepository(PainTrackerPTContext context)
        {
            _context = context;
            _dbSet = _context.FollowupsLog;
        }

        public Task<List<FollowupsLog>> SelectAll()
        {
            return _dbSet.ToListAsync();
        }

        public Task<FollowupsLog> SelectById(Guid? id)
        {
            return _dbSet.FirstOrDefaultAsync(m => m.Id == id);
        }

        public void Update(FollowupsLog followupsLog)
        {
            _dbSet.Update(followupsLog);
            _context.SaveChangesAsync();
        }

        public async void Remove(Guid id)
        {
            FollowupsLog followupsLogs = await _dbSet.FindAsync(id);
            _dbSet.Remove(followupsLogs);
            _context.SaveChangesAsync();
        }

        public void Insert(FollowupsLog followupsLog)
        {
            _dbSet.Add(followupsLog);
            _context.SaveChangesAsync();
        }

        public bool Exists(Guid id)
        {
            return _dbSet.Any(e => e.Id == id);
        }
    }
}
