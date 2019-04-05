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

        public MedicineRepository()
        {         
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
