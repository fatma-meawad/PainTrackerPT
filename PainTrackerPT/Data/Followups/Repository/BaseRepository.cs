using PainTrackerPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;
using Microsoft.EntityFrameworkCore;

namespace PainTrackerPT.Data.Followups.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        internal PainTrackerPTContext _db;
        private DbSet<T> _dbSet;

        public BaseRepository(PainTrackerPTContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        public void Create(T entity)
        {
            this._dbSet.Add(entity);
            _db.SaveChanges();
        }

        public bool Exists(Int64 id)
        {
            return _dbSet.Any(e => e.Id == id);
        }

        public void Remove(Int64 id)
        {
            T entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                this.SaveAsync();
            }
        }

        public async Task<Int64> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

        public async Task<T> Select(Int64 id)
        {
            return _dbSet.Find(id);

        }

        public async Task<IEnumerable<T>> SelectAll()
        {
            return await _dbSet.ToArrayAsync();
        }

        public void Update(T entity)
        {
            T existingEntity = _dbSet.Find(entity.Id);
            _dbSet.Update(entity);
            this.SaveAsync();
        }
    }
}
