using PainTrackerPT.Data.Followups.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Followups.Services
{
    public class BaseService : IBaseService
    {
        private IBaseRepository baseRepository;

        public BaseService(BaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }
    }
}
