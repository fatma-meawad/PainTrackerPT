using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    interface IDoctorTrend:ITrend
    {
        KeyValuePair<DateTime, int> PlotFollowUps();
    }
}
