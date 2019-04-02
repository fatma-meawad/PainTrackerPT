using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Doctors;
using Microsoft.EntityFrameworkCore;

namespace PainTrackerPT.Data.Doctor
{
    public class DataGateway<T> : IDataGateway<T> where T : class
    {
        public DataGateway() { }

        public DataGateway<T> dataGateway;

        private readonly PainTrackerPTContext db;
        internal DbSet<T> data = null;


        public DataGateway(PainTrackerPTContext sqlConnection)
        {
            db = sqlConnection;
            data = db.Set<T>();
        }

        public DataGateway(DataGateway<T> _dataGateway)
        {
            dataGateway = _dataGateway;
        }

        public void Insert(T obj)
        {
            db.Add(obj);
            db.SaveChanges();
            return;
        }

        public void Delete(int? id)
        {
            T obj = data.Find(id);
            data.Remove(obj);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<T> SelectAll()
        {
            return data.ToList();
        }

        public T SelectById(int? id)
        {
            return data.Find(id);
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
