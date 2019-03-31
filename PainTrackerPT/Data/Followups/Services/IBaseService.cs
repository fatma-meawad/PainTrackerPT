using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Followups.Repository
{
    public interface IBaseService <T> 
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        Task<T> Select(Guid id);
        Task<IEnumerable<T>> SelectAll();
        bool Exists(Guid id);
    }
}
