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
        bool NewestFirst;

        public SleepTrend(List<Sleep> SleepList)
        {
            this.SleepList = SleepList;
        }


        public List<KeyValuePair<DateTime, int>> PlotGraph()
        {
            var SleepPlots = new List<KeyValuePair<DateTime, int>>();
            NewestFirst = false;
            foreach (Sleep item in this)
            {
                SleepPlots.Add(new KeyValuePair<DateTime, int>(item.Date, item.SleepHours));
            }
            return SleepPlots;
        }

        public List<KeyValuePair<int, int>> PlotPie()
        {
            var SleepRows = new List<KeyValuePair<int, int>>();
            NewestFirst = true;
            foreach (Sleep item in this)
            {
                SleepRows.Add(new KeyValuePair<int, int>(item.ComfortLevel, item.Tiredness));
            }
            return SleepRows;
        }

        public override IEnumerator GetEnumerator()
        {
            return new SleepTrendIterator(SleepList,NewestFirst);
        }
    }
}
