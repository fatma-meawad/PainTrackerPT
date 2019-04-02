using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineLog<T>
    {
        T GetLogAt(DateTime dt);
        T GetLogFromTo(DateTime start_dt, DateTime end_dt);
        IEnumerable<T> SelectAll();
        IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID);
        IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID);
        IEnumerable<MedicineEvent> SelectMedEventById(int medicineID);
        IEnumerable<MedicineLog> SelectMedLogById(int patientID, int medicineID);
        void Insert(T obj);
        T SelectById(int? id);
        void Update(T obj);
        void Delete(int? id);
    }
}
