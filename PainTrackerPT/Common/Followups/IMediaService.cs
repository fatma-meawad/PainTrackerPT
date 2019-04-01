using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IMediaService
    {
        void Create(Media media);
        void UpdateMedia(Guid id, Media media);
        void DeleteMedia(Guid id);
        Task<Media> Select(Guid id);
        Task<IEnumerable<Media>> SelectAll();
    }
}