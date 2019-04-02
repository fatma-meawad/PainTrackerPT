using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PainTrackerPT.Models.Analytics.GFPatient;
using PainTrackerPT.Trends.Iterator;

namespace PainTrackerPT.Trends.Aggregate
{
    public class PainIntensityTrend : TrendAggregate, IPatientTrend
    {
        List<PainIntensity> PainIntensities;

        public PainIntensityTrend(List<PainIntensity> PainIntensityList)
        {
            PainIntensities = PainIntensityList;
        }

        public List<KeyValuePair<DateTime, int>> PlotGraph()
        {
            var PainIntensityPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (PainIntensity item in this)
            {
                PainIntensityPlots.Add(new KeyValuePair<DateTime, int>(item.Date, item.PainRating));
            }
            return PainIntensityPlots;
        }

        public List<KeyValuePair<int, int>> PlotPie()
        {
            var PainAreaPieList = new List<KeyValuePair<int, int>>();
            var PainAreaPieGroup = from item in PainIntensities
                                   group item by item.PainArea into g
                                   select new { g.Key, Count = g.Count() };

            foreach (var pa in PainAreaPieGroup)
            {
                PainAreaPieList.Add(new KeyValuePair<int, int>(pa.Key, pa.Count));
            }
            return PainAreaPieList;

        }

        public override IEnumerator GetEnumerator()
        {
            return new PainIntensityTrendIterator(this.PainIntensities);
        }
    }
}
