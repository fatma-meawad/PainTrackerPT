using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.PainDiary
{
    interface ILog
    {
        void getMood(String mood);
        void getLogDetails(int id);
    }
}
