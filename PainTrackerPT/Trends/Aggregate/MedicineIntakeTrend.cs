using System;
using System.Collections;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using PainTrackerPT.Trends.Iterator;

namespace PainTrackerPT.Trends.Aggregate
{
    public class MedicineIntakeTrend : TrendAggregate, IPatientTrend
    {
        List<MedicineIntake> MedicineIntakeList;

        public MedicineIntakeTrend(List<MedicineIntake> MedicineIntakeList)
        {
            this.MedicineIntakeList = MedicineIntakeList;
        }

        public override IEnumerator GetEnumerator()
        {
            return new MedicineIntakeTrendIterator(MedicineIntakeList);
        }

        public List<KeyValuePair<DateTime, int>> PlotGraph()
        {
            var MedicineIntakePlots = new List<KeyValuePair<DateTime, int>>();
            foreach (MedicineIntake item in this)
            {
                MedicineIntakePlots.Add(new KeyValuePair<DateTime, int>(item.Date, Convert.ToInt32(item.Dosage)));
            }
            return MedicineIntakePlots;
        }

        public List<KeyValuePair<int, int>> PlotPie()
        {
            throw new NotImplementedException();
        }
    }
}
