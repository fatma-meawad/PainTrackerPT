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
        internal PainTrackerPTContext db;
        private DbSet<T> dbSet;

        public BaseRepository(PainTrackerPTContext db)
        {
            dbSet = db.Set<T>();
        }

        public void Create(T entity)
        {
            this.dbSet.Add(entity);
            db.SaveChanges();
        }

        public bool Exists(Guid id)
        {
            return dbSet.Any(e => e.Id == id);
        }

        public void Remove(Guid id)
        {
            T entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                this.SaveAsync();
            }
        }

        public async Task<int> SaveAsync()
        {
            return await db.SaveChangesAsync();
        }

        public async Task<T> Select(Guid id)
        {
            return dbSet.Find(id);

        }

        public async Task<IEnumerable<T>> SelectAll()
        {
            return await dbSet.ToArrayAsync();
        }

        public void Update(T entity)
        {
            T existingEntity = dbSet.Find(entity.Id);
            dbSet.Update(entity);
            this.SaveAsync();
        }
    }
}
