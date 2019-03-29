using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class MedicineIntakeEventAPI : IMedicineIntakeEventAPI
    {
        private readonly IMedicineService<MedicineEvent> _medService;
        
        public MedicineIntakeEventAPI(IMedicineService<MedicineEvent> medService)
        {
            _medService = medService;
        }
   
        public IEnumerable<MedicineEvent> GetMedicineEvent(int medicineID)
        {
            return _medService.SelectMedEventById(medicineID);            
        }
    }
}
