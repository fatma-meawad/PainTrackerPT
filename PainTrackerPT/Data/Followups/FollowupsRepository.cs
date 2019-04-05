using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data
{
    public class FollowupsRepository : IFollowupsLogsRepository
    {

        private readonly PainTrackerPTContext _context;
        private DbSet<FollowupsLog> _dbSet;

        public FollowupsRepository(PainTrackerPTContext context)
        {
            _context = context;
            _dbSet = _context.FollowupsLog;
        }

        public async Task<List<FollowupsLog>> SelectAll()
        {
            return await _dbSet.ToListAsync();
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
            var followupsLog = await _dbSet.FindAsync(id);
            _dbSet.Remove(followupsLog);
            await _context.SaveChangesAsync();
        }

        public void Insert(FollowupsLog followupsLog)
        {
            followupsLog.Id = new Guid();
            _context.Add(followupsLog);
            _context.SaveChangesAsync();
        }

        public bool Exists(Guid id)
        {
            return _dbSet.Any(e => e.Id == id);
        }
    }
}
