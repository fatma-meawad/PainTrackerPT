using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class MedicineDataAPI : IMedicineDataAPI
    {
        private readonly IMedicineService<MedicineLog> _medService;

        public MedicineDataAPI(IMedicineService<MedicineLog> medService)
        {
            _medService = medService;
        }

        public IEnumerable<MedicineLog> GetMedicine(int patientID, int medicineID)
        {
            return _medService.SelectMedLogById(patientID, medicineID); 
        }
    }
}
