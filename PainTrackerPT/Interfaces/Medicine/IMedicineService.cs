using PainTrackerPT.Models.Medicine;
using PainTrackerPT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineService<T>
    {
        T GetLogAt(DateTime dt);
        T GetLogFromTo(DateTime start_dt, DateTime end_dt);
        IEnumerable<T> SelectAll();
        IEnumerable<MedicineEvent> GetMedicineEventList(int id);
        IEnumerable<MedicineEvent> SelectMedEventById(int medicineID);
        IEnumerable<MedicineLog> SelectMedLogById(int patientID, int medicineID);
        void Insert(T obj);
        T SelectById(int? id);
        void Update(T obj);
        void Delete(int? id);

    }
}
