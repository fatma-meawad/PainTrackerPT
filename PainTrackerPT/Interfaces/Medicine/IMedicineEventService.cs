using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Interfaces.Medicine
{
    public interface IMedicineEventService
    {
        IEnumerable<MedicineEvent> SelectMedEventById(int medicineID);
        void Insert(MedicineEvent obj);
        IEnumerable<MedicineEvent> GetMedicineEventList(int medID, int eventID);
        void Update(MedicineEvent obj);
        MedicineEvent SelectById(int? id);
        void Delete(int? id);
        IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID);


        //MedicineEvent GetLogAt(DateTime dt);
        //MedicineEvent GetLogFromTo(DateTime start_dt, DateTime end_dt);
        //IEnumerable<MedicineEvent> SelectAll();        
        void InsertEventLog(MedicineEventLog obj);



    }
}
