using PainTrackerPT.Data.Followups.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Followups.Services
{
    public class BaseService : IBaseService
    {
        private IBaseRepository <T> baseRepository;

        public BaseService(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public void Create(entity 1, T 2)
        {
            throw new NotImplementedException();
        }

        public void Delete(id 1, Guid 2)
        {
            throw new NotImplementedException();
        }

        public void Select(id 1, Guid 2)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(entity 1, T 2)
        {
            throw new NotImplementedException();
        }
    }
}
