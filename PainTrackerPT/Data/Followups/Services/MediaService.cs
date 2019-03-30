using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Common.Followups;

namespace PainTrackerPT.Data.Followups
{
    public class MediaService : IMediaService{
        private MediaRepository _mediaRepository;

        public void CreateNewMedia(Media media)
        {
            this._mediaRepository.Create(media);
        }
        
        public void DeleteMedia(Guid id)
        {
            this._mediaRepository.Remove(id);
        }

        public Task<Media> Select(Guid id)
        {
            return this._mediaRepository.Select(id);
        }

        public Task<IEnumerable<Media>> SelectAll()
        {
            return this._mediaRepository.SelectAll();
        }

   
        public void UpdateMedia(Guid id, Media media)
        {
            this._mediaRepository.Update(media);
        }
    }
}
