using System;
using System.Collections;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using PainTrackerPT.Trends.Iterator;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends.Aggregate
{
    public class InterferenceTrend : TrendAggregate, IPatientPatternTrend
    {
        List<Interference> InterferenceTrendList;
        public InterferenceTrend(List<Interference> InterferenceTrendList)
        {
            this.InterferenceTrendList = InterferenceTrendList;
        }

        public List<KeyValuePair<DateTime, int>> PlotGraph()
        {
            var InterferencePlots = new List<KeyValuePair<DateTime, int>>();
            foreach (Interference item in this)
            {
                InterferencePlots.Add(new KeyValuePair<DateTime, int>(item.Date,item.Severity));
            }
            return InterferencePlots;
        }

        public List<KeyValuePair<int, int>> PlotPie()
        {
            throw new NotImplementedException();
        }

        public override IEnumerator GetEnumerator()
        {
            return new InterferenceTrendIterator(InterferenceTrendList);
        }

        public List<KeyValuePair<string, int>> RetrievePattern()
        {
            var InterferenceRows = new List<KeyValuePair<String, int>>();
            foreach (var item in InterferenceTrendList)
            {
                InterferenceRows.Add(new KeyValuePair<String, int>(item.Description, item.Duration));
            }
            return InterferenceRows;
        }
    }
}
