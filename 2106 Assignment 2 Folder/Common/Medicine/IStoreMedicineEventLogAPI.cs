using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IStoreMedicineEventLogAPI
    {        
        void StoreEventLog(MedicineEventLog eventLog);        
    }
}
