using System;
using System.Collections;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public override IEnumerator GetEnumerator()
        {
            return new PainIntensityTrendIterator(this.PainIntensities);
        }
    }
}
