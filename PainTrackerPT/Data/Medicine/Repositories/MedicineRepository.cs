using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PainTrackerPT.Repository
{
    public class MedicineRepository : IMedicineLog
    {
        PainTrackerPTContext context = new PainTrackerPTContext();   
        DbSet<MedicineLog> data = null;
        //private readonly PainTrackerPTContext context;

        public MedicineRepository()//PainTrackerPTContext _context)
        {
            //context = _context;
            this.data = context.Set<MedicineLog>();            
        }

        public MedicineLog GetLogAt(DateTime dt)
        {          
            return null;
        }

        public IEnumerable<MedicineLog> SelectAll()
        {
            return data.ToList();
        }

        //public IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID)
        //{
        //    var query = (from medEvent in context.MedicineEvent                   
        //                 where medEvent.MedId == medID 
        //                 & medEvent.EventId == eventID
        //                 select medEvent).ToList();
        //    return query;
        //}

        //public IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID)
        //{
        //    var query = (from medEventLog in context.MedicineEventLog
        //                 where medEventLog.EventId == eventID                      
        //                 select medEventLog).ToList();
        //    return query;
        //}

        //public IEnumerable<MedicineEvent> SelectMedEventById(int medicineID)
        //{            
        //    var query = (from medEvent in context.MedicineEvent
        //                 where medEvent.MedId == medicineID
        //                 orderby medEvent.EventId
        //                 select medEvent).ToList();
        //    return query;
        //}

        public IEnumerable<MedicineLog> SelectMedLogById(int patientID)
        {
            var query = (from medLog in context.MedicineLog
                         where medLog.PatientID == patientID
                         orderby medLog.Id
                         select medLog).ToList();
            return query;
        }

        public void Insert(MedicineLog obj)
        {
            data.Add(obj);
            Save();
        }

        public MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt)
        {
            throw new NotImplementedException();
        }

        public MedicineLog SelectById(int? id)
        {
            return data.Find(id);
        }

        public void Save()
        {
            context.SaveChangesAsync();
        }

        public void Update(MedicineLog obj)
        {
            data.Update(obj);
            Save();
        }

        public void Delete(int? id)
        {
            MedicineLog obj = data.Find(id);
            data.Remove(obj);
            Save();
            
        }
    }
}
