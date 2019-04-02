using System;
using System.Collections.Generic;
using System.Linq;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Trends.Iterator
{
    public class SleepTrendIterator : Iterator
    {
        List<Sleep> SleepList;
        int Position = 0;
        int Flag = 0;

        public SleepTrendIterator(List<Sleep> SleepList, bool NewestFirst)
        {
            if(NewestFirst)
                this.SleepList = SleepList.OrderByDescending(i => i.Date).ToList();
            else
                this.SleepList = SleepList.OrderBy(i => i.Date).ToList();
        }


        public override object Current()
        {
            return SleepList[Position];
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

            else if (updatedPosition >= 0 && updatedPosition < SleepList.Count)
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
