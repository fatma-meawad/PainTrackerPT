using System;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    public class PatientTrend : IPatientTrend
    {
        public List<KeyValuePair<DateTime, int>> PlotInterference(List<Interference> interferencelist)
        {
            var InterferencePlots = new List<KeyValuePair<DateTime, int>>();
            foreach(var item in interferencelist)
            {   
                InterferencePlots.Add(new KeyValuePair<DateTime, int>(item.date,item.severity));
            }
            return InterferencePlots;
        }

        public List<KeyValuePair<DateTime, int>> PlotMood(List<Mood> moodlist)
        {
            var MoodPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (var item in moodlist)
            {
                MoodPlots.Add(new KeyValuePair<DateTime, int>(item.date, item.duration));
            }
            return MoodPlots;
        }

        public List<KeyValuePair<DateTime, int>> PlotPainIntensity(List<PainIntensity> painIntensities)
        {
            var painIntensityPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (var item in painIntensities)
            {
                painIntensityPlots.Add(new KeyValuePair<DateTime, int>(item.date, item.painRating));
            }
            return painIntensityPlots;
        }

        public List<KeyValuePair<DateTime, int>> PlotSleep(List<Sleep> sleep)
        {
            throw new NotImplementedException();
        }
    }
}
