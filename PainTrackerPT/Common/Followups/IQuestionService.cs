using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IQuestionService
    {
        void CreateNewQuestion(Question question);
        void UpdateQuestion(Guid id, Question question);
        void DeleteQuestion(Guid id);
        Task<Question> Select(Guid id);
        Task<IEnumerable<Question>> SelectAll();
    }
}
