using System;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    public interface IPatientTrend:ITrend
    {
        List<KeyValuePair<DateTime, int>> PlotInterference();
        List<KeyValuePair<DateTime, int>> PlotMood();
        List<KeyValuePair<DateTime, int>> PlotSleep();
    }
}
