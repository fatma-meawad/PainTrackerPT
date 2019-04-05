using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Interfaces.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class MedicineIntakeEventAPI
    {
        private readonly IMedicineEventService _medService;

        //uses dependency injection so that no initalisation in this class is needed
        public MedicineIntakeEventAPI(IMedicineEventService medService)
        {
            _medService = medService;
        }
   
        public IEnumerable<MedicineEvent> GetMedicineEvent(int medicineID)
        {
            return _medService.SelectMedEventById(medicineID);            
        }

        public IEnumerable<MedicineEventLog> GetMedicineEventLogList(int eventID)
        {
            return _medService.GetMedicineEventLogList(eventID);
        }
    }
}
