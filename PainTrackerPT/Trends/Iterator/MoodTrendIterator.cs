using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends.Iterator
{
    public class MoodTrendIterator : IPatientTrend
    {
        public List<KeyValuePair<DateTime, int>> PlotGraph()
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<int, int>> PlotPie()
        {
            throw new NotImplementedException();
        }
    }
}
