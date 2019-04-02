using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Data.Analytics
{
    public interface IGFPatientMedicineIntakeGateway
    {
            List<MedicineIntake> SelectAll();
    }
}
