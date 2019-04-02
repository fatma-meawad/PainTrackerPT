using System.Collections.Generic;

namespace PainTrackerPT.Trends
{
    public interface IPatientTrend:ITrend
    {
        List<KeyValuePair<int, int>> PlotPie();
    }
}
