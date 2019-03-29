
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

namespace PainTrackerPT.Data.Followups
{
    public class AnswerService : IAnswerService{
        private IAnswerRepository _answerRepsitory;

        public AnswerService()
        {
            this._answerRepsitory = new AnswerRepository();
        }

        public void CreateNewAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnswer(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Answer> Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateAnswer(Guid id, Answer answer)
        {
            throw new NotImplementedException();
        }
    }
}
