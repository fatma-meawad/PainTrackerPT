using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineLog
    {
        MedicineLog GetLogAt(DateTime dt);
        MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt);
        IEnumerable<MedicineLog> SelectAll();
        //IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID);
        //IEnumerable<MedicineEvent> SelectMedEventById(int medicineID);
        IEnumerable<MedicineLog> SelectMedLogById(int patientID);
        void Insert(MedicineLog obj);
        MedicineLog SelectById(int? id);
        void Update(MedicineLog obj);
        void Delete(int? id);
    }
}
