using System;
using System.Collections.Generic;
using PainTrackerPT.Models.Analytics.GFPatient;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    public interface ITrend
    {
        List<KeyValuePair<DateTime, int>> PlotGraph();
        List<KeyValuePair<int, int>> PlotPie();
    }
}
