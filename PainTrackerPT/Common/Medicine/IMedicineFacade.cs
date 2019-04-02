using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    interface IMedicineFacade
    {
        //uses facade pattern which hides complex backend functions with just 1 interface for client to call
        Dictionary<string, IEnumerable<MedicineEvent>> GetMedicineData(int patientID);
    }
}
