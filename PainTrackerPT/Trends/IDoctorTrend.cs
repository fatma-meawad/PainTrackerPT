using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    interface IDoctorTrend:ITrend
    {
        List<KeyValuePair<int, int>> PlotHeatMap();
    }
}
