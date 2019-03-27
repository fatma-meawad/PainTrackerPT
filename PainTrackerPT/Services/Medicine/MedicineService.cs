using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Services
{
    public class MedicineService<T> : IMedicineService<T> where T: class
    {
        private readonly IMedicineLog<T> _medLog;
      

        public MedicineService(IMedicineLog<T> medLog)
        {
            _medLog = medLog;
        }

        public IEnumerable<T> SelectAll()
        {
            return _medLog.SelectAll();
        }

        public void Insert(T obj)
        {
            _medLog.Insert(obj);
        }

        public T GetLogAt(DateTime dt)    
        {
            return _medLog.GetLogAt(dt);
        }

        public T GetLogFromTo(DateTime start_dt, DateTime end_dt)
        {
            throw new NotImplementedException();
        }

        public T SelectById(int? id)
        {
            return _medLog.SelectById(id);
        }

        public void Update(T obj)
        {
             _medLog.Update(obj);
        }

        public void Delete(int? id)
        {
            _medLog.Delete(id); 
        }

    }
}
