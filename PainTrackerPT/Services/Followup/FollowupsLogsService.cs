using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Data;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Services.Followup
{
    public class FollowupsLogsService : IFollowupsLogsService
    {
        private IFollowupsLogsRepository _followupsRepository;

        public FollowupsLogsService(IFollowupsLogsRepository followupsLogsRepository)
        {
            _followupsRepository = followupsLogsRepository;
        }

        public Task<List<FollowupsLog>> SelectAll()
        {
            return _followupsRepository.SelectAll();
        }

        public Task<FollowupsLog> SelectById(Guid? id)
        {
            return _followupsRepository.SelectById(id);
        }

        public void Update(FollowupsLog followupsLog)
        {
            _followupsRepository.Update(followupsLog);
        }

        public void Remove(Guid id)
        {
            _followupsRepository.Remove(id);
        }

        public void Insert(FollowupsLog followupsLog)
        {
            _followupsRepository.Insert(followupsLog);
        }

        public bool Exists(Guid id)
        {
            return _followupsRepository.Exists(id);
        }
    }
}
