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
        void Delete(Guid id);
        Task<FollowUp> Select(Guid id);
        Task<IEnumerable<FollowUp>> SelectAll();
    }
}
