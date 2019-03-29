using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IFollowUpService
    {
        void CreateNewFollowUp(FollowUp followUp);
        void UpdateFollowUp(Guid id, FollowUp followUp);
        void DeleteFollowUp(Guid id);
        Task<FollowUp> Select(Guid id);
        Task<IEnumerable<FollowUp>> SelectAll();
    }
}
