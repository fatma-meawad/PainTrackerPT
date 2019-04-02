using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PainTrackerPT.Models.Analytics.GFPatient;

namespace PainTrackerPT.Trends.Iterator
{
    public class PainIntensityTrendIterator : Iterator
    {
        List<PainIntensity> PainIntensities;
        int Position = 0;
        int Flag = 0;

        public PainIntensityTrendIterator(List<PainIntensity> PainIntensityList)
        {
            PainIntensities = PainIntensityList.OrderBy(i => i.Date).ToList();
            
        }

        public override object Current()
        {
            return PainIntensities[Position];
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

            else if (updatedPosition >= 0 && updatedPosition < PainIntensities.Count)
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
