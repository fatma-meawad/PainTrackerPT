using System.Collections;

namespace PainTrackerPT.Trends.Aggregate
{
    public abstract class TrendAggregate
    {
        public abstract IEnumerator GetEnumerator();
    }
}
