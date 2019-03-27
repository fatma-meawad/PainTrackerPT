using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    interface IMedicineIntakeEvent
    {
        MedicineLog GetLogAt(DateTime dt);
        MedicineLog GetLogFromTo(DateTime start_dt, DateTime end_dt);
    }
}
