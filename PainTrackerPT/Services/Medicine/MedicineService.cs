using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Services
{
    public class MedicineService : IMedicineService//<T> where T: class
    {
        private readonly IMedicineLog _medLog;
       // private readonly IMedicineLog<MedicineEvent> _medEvent;
       // private readonly IMedicineLog<MedicineLog> _medData;


        public MedicineService(IMedicineLog medLog)//, IMedicineLog<MedicineEvent> medEvent, IMedicineLog<MedicineLog> medData)
        {
            _medLog = medLog;
            //_medEvent = medEvent;
            //_medData = medData;
        }

        public IEnumerable<MedicineLog> SelectAll()
        {
            return _medLog.SelectAll();
        }

        //public IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID)
        //{
        //    return _medLog.GetMedicineEventList(medID, eventID);
        //}

        //public IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID)
        //{
        //    return _medLog.GetMedicineEventLogList(eventID);
        //}

        //public IEnumerable<MedicineEvent> SelectMedEventById(int medicineID)
        //{
        //    return _medLog.SelectMedEventById(medicineID);
        //}

        public IEnumerable<MedicineLog> SelectMedLogById(int patientID)
        {
            return _medLog.SelectMedLogById(patientID);
        }

        public void Insert(MedicineLog obj)
        {
            _medLog.Insert(obj);
        }

        public MedicineLog GetLogAt(DateTime dt)    
        {
            return _medLog.GetLogAt(dt);
        }

        public MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt)
        {
            throw new NotImplementedException();
        }

        public MedicineLog SelectById(int? id)
        {
            return _medLog.SelectById(id);
        }

        public void Update(MedicineLog obj)
        {
             _medLog.Update(obj);
        }

        public void Delete(int? id)
        {
            _medLog.Delete(id); 
        }

    }
}
