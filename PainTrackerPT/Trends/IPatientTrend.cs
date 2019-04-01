using System;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    public interface IPatientTrend:ITrend
    {
        List<KeyValuePair<DateTime, int>> PlotInterference(List<Interference> interferencelist);
        List<KeyValuePair<DateTime, int>> PlotMood(List<Mood> moodlist);
        List<KeyValuePair<DateTime, int>> PlotSleep(List<Sleep> sleep);
    }
}
