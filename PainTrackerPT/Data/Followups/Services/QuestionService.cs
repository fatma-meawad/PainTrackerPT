
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Data.Followups.Services;

namespace PainTrackerPT.Data.Followups
{
    public class QuestionService : BaseService
    {
        // TODO: DI THIS
        public QuestionService(IBaseRepository baseRepository) : base(baseRepository)
        {
        }

        public void CreateNewQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuestion(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Question> Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateQuestion(Guid id, Question question)
        {
            throw new NotImplementedException();
        }
    }
}
