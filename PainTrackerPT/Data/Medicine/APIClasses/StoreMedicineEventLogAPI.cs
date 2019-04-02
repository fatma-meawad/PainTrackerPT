using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class StoreMedicineEventLogAPI : IStoreMedicineEventLogAPI
    {
        private readonly IMedicineService<MedicineEventLog> _medService;

        public StoreMedicineEventLogAPI(IMedicineService<MedicineEventLog> medService)
        {
            _medService = medService;
        }

        public void StoreEventLog(MedicineEventLog eventLog)
        {
            _medService.Insert(eventLog);
        }
    }
}
