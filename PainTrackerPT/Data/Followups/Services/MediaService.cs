using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Data.Followups.Services;
using PainTrackerPT.Data.Followups.Repository;

namespace PainTrackerPT.Data.Followups
{
    public class MediaService : BaseService<Media>, IMediaService{

        public MediaService(IBaseRepository<Media> baseRepository): base(baseRepository)
        {       
        }

        public void CreateNewMedia(Media media)
        {
            this.Create(media);
        }

        public void DeleteMedia(Guid id)
        {
            this.Delete(id);
        }

        public void UpdateMedia(Media media)
        {
            this.Update(media);
        }
    }
}
