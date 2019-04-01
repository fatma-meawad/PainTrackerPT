using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PainTrackerPT.Repository
{
    public class MedicineRepository<T> : IMedicineLog<T> where T: class
    {
        PainTrackerPTContext context = new PainTrackerPTContext();   
        //internal PainTrackerPTContext db;
        DbSet<T> data = null;    

        public MedicineRepository()//PainTrackerPTContext _context)
        {
            //this.db = db;
            //context = _context;
            this.data = context.Set<T>();            
        }

        public T GetLogAt(DateTime dt)
        {          
            return null;
        }

        public IEnumerable<T> SelectAll()
        {
            return data.ToList();
        }

        public IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID)
        {
            var query = (from medEvent in context.MedicineEvent                   
                         where medEvent.MedId == medID 
                         & medEvent.EventId == eventID
                         select medEvent).ToList();
            return query;
        }

        public IEnumerable<MedicineEvent> SelectMedEventById(int medicineID)
        {            
            var query = (from medEvent in context.MedicineEvent
                         where medEvent.MedId == medicineID
                         orderby medEvent.EventId
                         select medEvent).ToList();
            return query;
        }

        public IEnumerable<MedicineLog> SelectMedLogById(int patientID, int medicineID)
        {
            var query = (from medLog in context.MedicineLog
                         //where medLog.Id == medicineID
                         orderby medLog.Id
                         select medLog).ToList();
            return query;
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
            context.SaveChangesAsync();
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
