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
        public async Task<IEnumerable<Media>> SelectAllByAnswerId(Int64 answerId)
        {
            return await ((MediaRepository)_baseRepository).SelectAllByAnswerId(answerId);
        }

    }
}
