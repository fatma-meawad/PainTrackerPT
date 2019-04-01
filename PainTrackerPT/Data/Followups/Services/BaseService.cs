using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models.Followups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Followups.Services
{
    public class BaseService <T> : IBaseService <T> where T: BaseEntity
    {
        protected IBaseRepository <T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            this._baseRepository = baseRepository;
        }

        public void Create(T entity)
        {
            _baseRepository.Create(entity);
        }

        public void Delete(Int64 id)
        {
            _baseRepository.Remove(id);
        }

        public bool Exists(Int64 id)
        {
            return _baseRepository.Exists(id);
        }

        public Task<T> Select(Int64 id)
        {
            return _baseRepository.Select(id);
        }

        public Task<IEnumerable<T>> SelectAll()
        {
            return _baseRepository.SelectAll();
        }

        public void Update(T entity)
        {
            _baseRepository.Update(entity);
        }
    }
}
