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
    public interface IMediaRepository
    {
        void Create(AbstractMedia media);
        Task<IEnumerable<AbstractMedia>> SelectAll();
        Task<AbstractMedia> SelectById(Guid id);
        void Update(AbstractMedia media);
        void Remove(Guid id);
        Task<int> Save();
    }

    public class MediaRepository : IMediaRepository
    {
        private DbSet<AbstractMedia> _mediaDbSet;

        public void Create(AbstractMedia media)
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

        public Task<IEnumerable<AbstractMedia>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<AbstractMedia> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(AbstractMedia media)
        {
            throw new NotImplementedException();
        }
    }
}
