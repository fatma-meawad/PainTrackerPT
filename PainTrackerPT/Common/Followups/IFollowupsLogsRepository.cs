using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IFollowupsLogsRepository
    {
        Task<List<FollowupsLog>> SelectAll();
        Task<FollowupsLog> SelectById(Guid? id);
        void Update(FollowupsLog followupsLog);
        void Remove(Guid id);
        void Insert(FollowupsLog followupsLog);
        Boolean Exists(Guid id);
    }
}
