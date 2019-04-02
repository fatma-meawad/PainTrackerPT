using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Trends.Iterator
{
    public class InterferenceTrendIterator : Iterator
    {
        List<Interference> InterferenceTrendList;
        int Position = 0;
        int Flag = 0;


        public InterferenceTrendIterator(List<Interference> InterferenceTrendList, bool NewestFirst)
        {
            if(NewestFirst)
                this.InterferenceTrendList = InterferenceTrendList.OrderByDescending(i => i.Date).ToList();
            else
                this.InterferenceTrendList = InterferenceTrendList.OrderBy(i => i.Date).ToList();
        }

        public override object Current()
        {
            return InterferenceTrendList[Position];
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

            else if (updatedPosition >= 0 && updatedPosition < InterferenceTrendList.Count)
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
