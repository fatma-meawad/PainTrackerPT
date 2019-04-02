using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class MedicineDataAPI 
    {
        private readonly IMedicineService _medService;

        public MedicineDataAPI()
        {
       
        }

        //uses dependency injection so that no initalisation in this class is needed
        public MedicineDataAPI(IMedicineService medService)
        {
            _medService = medService;
        }

        public IEnumerable<MedicineLog> GetMedicine(int patientID)
        {
            return _medService.SelectMedLogById(patientID);
        }

    }
}