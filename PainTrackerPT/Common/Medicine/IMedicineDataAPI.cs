using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineDataAPI
    {
        //Team Analytics's methods
        IEnumerable<MedicineLog> GetMedicine(int patientID, int medicineID);
    }
}
