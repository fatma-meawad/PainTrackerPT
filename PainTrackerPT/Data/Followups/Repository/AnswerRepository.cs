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
    public interface IAnswerRepository
    {
        void Create(Answer answer);
        Task<IEnumerable<Answer>> SelectAll();
        Task<FollowUp> SelectById(Guid id);
        void Update(Answer answer);
        void Remove(Guid id);
        Task<int> Save();
    }

    public class AnswerRepository : IAnswerRepository
    {
        public void Create(Answer answer)
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

        public Task<IEnumerable<Answer>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<FollowUp> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Answer answer)
        {
            throw new NotImplementedException();
        }
    }
}
