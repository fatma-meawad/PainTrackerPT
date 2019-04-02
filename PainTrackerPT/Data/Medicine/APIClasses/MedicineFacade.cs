using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class MedicineFacade : IMedicineFacade
    {
        MedicineIntakeEventAPI _intakeEvent;
        MedicineDataAPI _medicineData;       
        Dictionary<string,IEnumerable<MedicineEvent>> medicineDictionary;

 

        public Dictionary<string, IEnumerable<MedicineEvent>> GetMedicineData(int patientID)
        {
            var medData = _medicineData.GetMedicine(patientID);

            //retrieve all the medicine recorded by the patient
            foreach(var medicine in medData)
            {                                
                //retrieve all schedules for the medicine
                var medEvent = _intakeEvent.GetMedicineEvent(medicine.Id);

                //store tallied data into dictionary for Analytics team
                medicineDictionary.Add(medicine.Name, medEvent);
            }
            return medicineDictionary;
        }
    }
}
