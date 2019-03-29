using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IAnswerService
    {
        void CreateNewAnswer(Answer answer);
        void UpdateAnswer(Guid id, Answer answer);
        void DeleteAnswer(Guid id);
        Task<Answer> Select(Guid id);
        Task<IEnumerable<Answer>> SelectAll();
    }
}
