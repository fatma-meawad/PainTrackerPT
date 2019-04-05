using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Interfaces.Medicine;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.Repositories
{
    public class MedicineEventRepository : IMedicineEventRepository
    {
        PainTrackerPTContext context = new PainTrackerPTContext();   
        DbSet<MedicineEvent> data = null;
        DbSet<MedicineEventLog> dataEventLog = null;        

        public MedicineEventRepository()
        {
            //context = _context;
            this.data = context.Set<MedicineEvent>();
        }
              

        public IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID)
        {
            var query = (from medEvent in context.MedicineEvent
                         where medEvent.MedId == medID
                         & medEvent.EventId == eventID
                         select medEvent).ToList();
            return query;
        }

        public IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID)
        {
            var query = (from medEventLog in context.MedicineEventLog
                         where medEventLog.EventId == eventID
                         select medEventLog).ToList();
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

        
        public void Insert(MedicineEvent obj)
        {
            data.Add(obj);
            Save();
        }

       

        public MedicineEvent GetLogFromTo(DateTime start_dt, DateTime end_dt)
        {
            throw new NotImplementedException();
        }

        public MedicineEvent SelectById(int? id)
        {
            return data.Find(id);
        }

        public void Save()
        {
            context.SaveChangesAsync();
        }

        public void Update(MedicineEvent obj)
        {
            data.Update(obj);
            Save();
        }

        public void Delete(int? id)
        {
            MedicineEvent obj = data.Find(id);
            data.Remove(obj);
            Save();

        }

        public void InsertEventLog(MedicineEventLog obj)
        {
            dataEventLog.Add(obj);
            Save();
        }

        //public MedicineEvent GetLogAt(DateTime dt)
        //{
        //    return null;
        //}

        //public IEnumerable<MedicineEvent> SelectAll()
        //{
        //    return data.ToList();
        //}

        //public IEnumerable<MedicineLog> SelectMedLogById(int patientID)
        //{
        //    var query = (from medLog in context.MedicineLog
        //                 where medLog.PatientID == patientID
        //                 orderby medLog.Id
        //                 select medLog).ToList();
        //    return query;
        //}

    }
}
