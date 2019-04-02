using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Interfaces.Medicine
{
    public interface IMedicineEventRepository
    {
        
        MedicineEvent GetLogFromTo(DateTime start_dt, DateTime end_dt);
     
        IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID);
        IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID);
        IEnumerable<MedicineEvent> SelectMedEventById(int medicineID);
 
        void Insert(MedicineEvent obj);
      
        MedicineEvent SelectById(int? id);
        void Update(MedicineEvent obj);
        void Delete(int? id);

        //MedicineEvent GetLogAt(DateTime dt);
        //IEnumerable<MedicineEvent> SelectAll();
        //IEnumerable<MedicineLog> SelectMedLogById(int patientID);
        void InsertEventLog(MedicineEventLog obj);
    }
}
