using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineIntakeEventAPI
    {
        //Team Analytics's methods        
        IEnumerable<MedicineEvent> GetMedicineEvent(int medicineID);

        //Dr Fatma's Methods
        //MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt);
      
    }
}
