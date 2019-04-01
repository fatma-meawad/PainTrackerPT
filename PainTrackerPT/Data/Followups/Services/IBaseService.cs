using PainTrackerPT.Models.Followups;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Followups.Repository
{
    public interface IBaseService <T> where T: BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Int64 id);
        Task<T> Select(Int64 id);
        Task<IEnumerable<T>> SelectAll();
        bool Exists(Int64 id);
    }
}
