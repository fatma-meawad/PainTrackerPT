using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups
{
    public interface IQuestionRepository
    {
        void Create(Question question);
        Task<IEnumerable<Question>> SelectAll();
        Task<Question> SelectById(Guid id);
        void Update(Question question);
        void Remove(Guid id);
        Task<int> Save();
    }

    public class QuestionRepository : IQuestionRepository
    {
        public void Create(Question question)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Question> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Question question)
        {
            throw new NotImplementedException();
        }
    }
}
