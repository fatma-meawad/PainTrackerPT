using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineFacade
    {
        //uses facade pattern which hides complex backend functions with just 1 interface for client to call
        IDictionary<string, IEnumerable<MedicineEventLog>> GetMedicineData(int patientID);     

    }
}
