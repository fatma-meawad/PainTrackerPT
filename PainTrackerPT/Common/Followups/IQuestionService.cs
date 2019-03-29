using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Followups
{
    public interface IQuestionService
    {
        void CreateNewFollowUp(FollowUp followUp);
        void UpdateFollowUp(Guid id, FollowUp followUp);
        void DeleteFollowUp(Guid id);
        void Select(Guid id);
        void SelectAll();
    }
}
