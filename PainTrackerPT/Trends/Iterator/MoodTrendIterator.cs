using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Trends.Iterator
{
    public class MoodTrendIterator : Iterator
    {
        List<Mood> MoodTrendList;
        int Position = 0;
        int Flag = 0;

        public MoodTrendIterator(List<Mood> MoodTrendList)
        {
            this.MoodTrendList = MoodTrendList.OrderBy(i => i.Date).ToList();
        }

        public override object Current()
        {
            return MoodTrendList[Position];
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

            else if (updatedPosition >= 0 && updatedPosition < MoodTrendList.Count)
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
