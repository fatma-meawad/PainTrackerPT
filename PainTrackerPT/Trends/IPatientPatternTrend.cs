using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Trends
{
    public interface IPatientPatternTrend: IPatientTrend
    {
        List<KeyValuePair<string, int>> RetrievePattern();
    }
}
