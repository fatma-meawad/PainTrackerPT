using PainTrackerPT.Common.Medicine;
using PainTrackerPT.Interfaces.Medicine;
using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Medicine.APIClasses
{
    public class MedicineFacade : IMedicineFacade
    {
        private MedicineIntakeEventAPI _intakeEvent;
        private MedicineDataAPI _medicineData;
        private IDictionary<string, IEnumerable<MedicineEventLog>> medicineDictionary;    

        public MedicineFacade(IMedicineEventService service, IMedicineService medService)
        {
            _intakeEvent = new MedicineIntakeEventAPI(service);
            _medicineData = new MedicineDataAPI(medService);
            medicineDictionary = new Dictionary<string, IEnumerable<MedicineEventLog>>();
        }

        public IDictionary<string, IEnumerable<MedicineEventLog>> GetMedicineData(int patientID)
        {
            var medData = _medicineData.GetMedicine(patientID);

            //retrieve all the medicine recorded by the patient
            foreach (var medicine in medData)
            {
                //retrieve all schedules for the medicine
                var medEvent = _intakeEvent.GetMedicineEvent(medicine.Id);

                foreach(var medLog in medEvent)
                {
                    var medicineLogs = _intakeEvent.GetMedicineEventLogList(medLog.EventId);

                    //store tallied data into dictionary for Analytics team
                    medicineDictionary.Add(medicine.Name, medicineLogs);
                }
                
            }
            return medicineDictionary;
        }

    }
}
