using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Common.Followups
{
    public interface IMediaService
    {
        void CreateNewMedia(AbstractMedia media);
        void UpdateMedia(Guid id, AbstractMedia media);
        void DeleteMedia(Guid id);
        Task<FollowUp> Select(Guid id);
        Task<IEnumerable<FollowUp>> SelectAll();
    }
}