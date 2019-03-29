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
        private readonly IMedicineLog<MedicineEvent> _medEvent;
        private readonly IMedicineLog<MedicineLog> _medData;


        public MedicineService(IMedicineLog<T> medLog, IMedicineLog<MedicineEvent> medEvent, IMedicineLog<MedicineLog> medData)
        {
            _medLog = medLog;
            _medEvent = medEvent;
            _medData = medData;
        }

        public IEnumerable<T> SelectAll()
        {
            return _medLog.SelectAll();
        }

        public IEnumerable<MedicineLog> GetMedicineNameList()
        {           
            return _medData.GetMedicineNameList();
        }

        public IEnumerable<MedicineEvent> SelectMedEventById(int medicineID)
        {
            return _medEvent.SelectMedEventById(medicineID);
        }

        public IEnumerable<MedicineLog> SelectMedLogById(int patientID, int medicineID)
        {
            return _medData.SelectMedLogById(patientID, medicineID);
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
