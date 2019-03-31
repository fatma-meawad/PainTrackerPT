using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {  
        void Create(T entity);
        Task<IEnumerable<T>> SelectAll();
        Task<T> Select(Guid id);
        void Update(T entity);
        void Remove(Guid id);
        Task<int> Save();
    }
}
