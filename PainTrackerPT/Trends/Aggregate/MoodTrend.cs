using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PainTrackerPT.Models.Analytics.GFPatient;
using PainTrackerPT.Trends.Iterator;

namespace PainTrackerPT.Trends.Aggregate
{
    public class MoodTrend : TrendAggregate, IPatientTrend
    {
        List<Mood> MoodTrendList;

        public MoodTrend(List<Mood> MoodTrendList)
        {
            this.MoodTrendList = MoodTrendList;
        }
        public List<KeyValuePair<DateTime, int>> PlotGraph()
        {
            var MoodPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (Mood item in this)
            {
                MoodPlots.Add(new KeyValuePair<DateTime, int>(item.Date, item.MoodType));
            }
            return MoodPlots;
        }

        public List<KeyValuePair<int, int>> PlotPie()
        {
            var MoodDoughnutList = new List<KeyValuePair<int, int>>();
            var MoodDoughnutGroup = from item in MoodTrendList
                                    group item by item.MoodType into g
                                    select new { g.Key, Count = g.Count() };

            foreach (var md in MoodDoughnutGroup)
            {
                MoodDoughnutList.Add(new KeyValuePair<int, int>(md.Key, md.Count));
            }

            return MoodDoughnutList;
        }

        public override IEnumerator GetEnumerator()
        {
            return new MoodTrendIterator(MoodTrendList);
        }
    }
}
