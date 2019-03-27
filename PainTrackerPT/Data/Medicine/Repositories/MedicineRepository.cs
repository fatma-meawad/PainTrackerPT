using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Repository
{
    public class MedicineRepository<T> : IMedicineLog<T> where T: class
    {
        PainTrackerPTContext context = new PainTrackerPTContext();
        DbSet<T> data = null;

        public MedicineRepository()
        {
            this.data = context.Set<T>();
        }

        public T GetLogAt(DateTime dt)
        {
            //var dbEntry = context.MedicineLog.FirstOrDefault(acc => acc.timeStamp == dt);
            //return dbEntry;
            return null;
        }

        public IEnumerable<T> SelectAll()
        {
            return data.ToList();
        }

        public void Insert(T obj)
        {
            data.Add(obj);
            Save();
        }

        public T GetLogFromTo(DateTime start_dt, DateTime end_dt)
        {
            throw new NotImplementedException();
        }

        public T SelectById(int? id)
        {
            return data.Find(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            data.Update(obj);
            Save();
        }

        public void Delete(int? id)
        {
            T obj = data.Find(id);
            data.Remove(obj);
            Save();
            
        }
    }
}
