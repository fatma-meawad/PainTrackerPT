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
    public class MediaService : IMediaService{
        private IMediaRepository _mediaRepository;

        public MediaService()
        {
            this._mediaRepository = new MediaRepository();
        }

        public void CreateNewMedia(AbstractMedia media)
        {
            throw new NotImplementedException();
        }

        public void DeleteMedia(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AbstractMedia> Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AbstractMedia>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateMedia(Guid id, AbstractMedia media)
        {
            throw new NotImplementedException();
        }
    }
}
