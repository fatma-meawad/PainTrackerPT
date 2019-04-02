using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Interface
{
    interface IPainLog<T>
    {

        T GetMood(String mood);
        T GetLogDetails(int id);
    }
}
