using PainTrackerPT.Models.Medicine;
using PainTrackerPT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineService
    {
        MedicineLog GetLogAt(DateTime dt);
        IEnumerable<MedicineLog> SelectAll();
        void Insert(MedicineLog obj);
        MedicineLog SelectById(int? id);
        void Update(MedicineLog obj);
        void Delete(int? id);

        MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt);
      
        //IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID);
        //IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID);
        //IEnumerable<MedicineEvent> SelectMedEventById(int medicineID);
        IEnumerable<MedicineLog> SelectMedLogById(int patientID);
        
       
     
       

    }
}
