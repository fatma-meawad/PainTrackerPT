using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Interfaces.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class StoreMedicineEventLogAPI : IStoreMedicineEventLogAPI
    {
        private readonly IMedicineEventService _medService;

        //uses dependency injection so that no initalisation in this class is needed
        public StoreMedicineEventLogAPI(IMedicineEventService medService)
        {
            _medService = medService;
        }

        public void StoreEventLog(MedicineEventLog eventLog)
        {
            _medService.InsertEventLog(eventLog);
        }
    }
}
