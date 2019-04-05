using PainTrackerPT.Interfaces.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Services.Medicine
{
    public class MedicineEventService : IMedicineEventService
    {
        private readonly IMedicineEventRepository _medEventRepo;  

        public MedicineEventService(IMedicineEventRepository medEventRepo)
        {
            _medEventRepo = medEventRepo;       
        }

        public IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID)
        {
            return _medEventRepo.GetMedicineEventList(medID, eventID);
        }

        public IEnumerable<MedicineEvent> SelectMedEventById(int medicineID)
        {
            return _medEventRepo.SelectMedEventById(medicineID);
        }

        public void Insert(MedicineEvent obj)
        {
            _medEventRepo.Insert(obj);
        }

        public MedicineEvent SelectById(int? id)
        {
            return _medEventRepo.SelectById(id);
        }

        public void Update(MedicineEvent obj)
        {
            _medEventRepo.Update(obj);
        }

        public void Delete(int? id)
        {
            _medEventRepo.Delete(id);
        }

        public IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID)
        {
            return _medEventRepo.GetMedicineEventLogList(eventID);
        }

        //public IEnumerable<MedicineEvent> SelectAll()
        //{
        //    return _medEventRepo.SelectAll();
        //}

        public void InsertEventLog(MedicineEventLog obj)
        {
            _medEventRepo.InsertEventLog(obj);
        }

        //public MedicineEvent GetLogAt(DateTime dt)
        //{
        //    return _medEventRepo.GetLogAt(dt);
        //}

        //public MedicineEvent GetLogFromTo(DateTime start_dt, DateTime end_dt)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
