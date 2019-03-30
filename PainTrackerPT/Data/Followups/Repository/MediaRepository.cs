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
        void Create(Media media);
        Task<IEnumerable<Media>> SelectAll();
        Task<Media> SelectById(Guid id);
        void Update(Media media);
        void Remove(Guid id);
        Task<int> Save();
    }

    public class MediaRepository : IMediaRepository
    {
        private DbSet<Media> _mediaDbSet;

        public void Create(Media media)
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

        public Task<IEnumerable<Media>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Media> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Media media)
        {
            throw new NotImplementedException();
        }
    }
}
