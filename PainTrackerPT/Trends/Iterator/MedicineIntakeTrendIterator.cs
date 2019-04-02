using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Trends.Iterator
{
    public class MedicineIntakeTrendIterator : Iterator
    {
        List<MedicineIntake> MedicineIntakeList;
        int Position = 0;
        int Flag = 0;

        public MedicineIntakeTrendIterator(List<MedicineIntake> MedicineIntakeList)
        {
            this.MedicineIntakeList = MedicineIntakeList.OrderBy(i => i.Date).ToList();
        }
        public override object Current()
        {
            return MedicineIntakeList[Position];
        }

        public override int Key()
        {
            return Position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = Position + 1;
            if (Flag == 0)
            {
                Flag = 1;
                return true;

            }

            else if (updatedPosition >= 0 && updatedPosition < MedicineIntakeList.Count)
            {
                Position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            Flag = 0;
            Position = 0;
        }
    }
}
