using System;
using System.Collections;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using PainTrackerPT.Trends.Iterator;

namespace PainTrackerPT.Trends.Aggregate
{
    public class SleepTrend : TrendAggregate, IPatientTrend
    {
        List<Sleep> SleepList;

        public SleepTrend(List<Sleep> SleepList)
        {
            this.SleepList = SleepList;
        }


        public List<KeyValuePair<DateTime, int>> PlotGraph()
        {
            var SleepPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (Sleep item in this)
            {
                SleepPlots.Add(new KeyValuePair<DateTime, int>(item.Date, item.SleepHours));
            }
            return SleepPlots;
        }

        public List<KeyValuePair<int, int>> PlotPie()
        {
            throw new NotImplementedException();
        }

        public override IEnumerator GetEnumerator()
        {
            return new SleepTrendIterator(SleepList);
        }
    }
}
