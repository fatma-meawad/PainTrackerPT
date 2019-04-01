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
        Task<T> Select(Int64 id);
        void Update(T entity);
        void Remove(Int64 id);
        Task<Int64> SaveAsync();
        bool Exists(Int64 id);
    }
}
