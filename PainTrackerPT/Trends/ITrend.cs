using System;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    public interface ITrend
    {
        List<KeyValuePair<DateTime, int>> PlotPainIntensity(List<PainIntensity> painIntensities);
    }
}
