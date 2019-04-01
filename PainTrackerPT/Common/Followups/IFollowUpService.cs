using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IFollowUpService
    {
        void Create(FollowUp followUp);
        void Update(FollowUp followUp);
        void Delete(Int64 id);
        Task<FollowUp> Select(Int64 id);
        Task<IEnumerable<FollowUp>> SelectAll();
    }
}
