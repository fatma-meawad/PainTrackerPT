using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Data.Analytics
{
    public class GFPatientMedicineIntakeGateway : IGFPatientMedicineIntakeGateway
    {
        private readonly PainTrackerPTContext _context;
        public GFPatientMedicineIntakeGateway(PainTrackerPTContext context)
        {
            _context = context;
        }

        public List<MedicineIntake> SelectAll()
        {
            List<MedicineIntake> MedicineIntakeList = new List<MedicineIntake>();
            //retrieve painDiary based on patient id
            MedicineIntakeList = _context.MedicineIntake.ToList();
            return MedicineIntakeList;

        }
    }
}
