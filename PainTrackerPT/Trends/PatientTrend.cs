using System;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    public class PatientTrend : IPatientTrend
    {
        List<Interference> InterferenceList;
        List<Mood> MoodList;
        List<PainIntensity> PainIntensities;
        List<Sleep> SleepList;
        PainDiary PainDiary;


        public PatientTrend(PainDiary PainDiary)
        {
            this.PainDiary = PainDiary;
            InterferenceList = PainDiary.Interference;
            PainIntensities = PainDiary.PainIntensity;
            MoodList = PainDiary.Mood;
            SleepList = PainDiary.Sleep;
        }



        public List<KeyValuePair<DateTime, int>> PlotInterference()
        {
            var InterferencePlots = new List<KeyValuePair<DateTime, int>>();
            foreach(var item in InterferenceList)
            {   
                InterferencePlots.Add(new KeyValuePair<DateTime, int>(item.date,item.severity));
            }
            return InterferencePlots;
        }

        public List<KeyValuePair<DateTime, int>> PlotMood()
        {
            var MoodPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (var item in MoodList)
            {
                MoodPlots.Add(new KeyValuePair<DateTime, int>(item.date, item.duration));
            }
            return MoodPlots;
        }

        public List<KeyValuePair<DateTime, int>> PlotPainIntensity()
        {
            var PainIntensityPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (var item in PainIntensities)
            {
                PainIntensityPlots.Add(new KeyValuePair<DateTime, int>(item.date, item.painRating));
            }
            return PainIntensityPlots;
        }

        public List<KeyValuePair<DateTime, int>> PlotSleep()
        {
            var SleepPlots = new List<KeyValuePair<DateTime, int>>();
            foreach (var item in SleepList)
            {
                SleepPlots.Add(new KeyValuePair<DateTime, int>(item.date, item.sleepHours));
            }
            return SleepPlots;
        }
    }
}
