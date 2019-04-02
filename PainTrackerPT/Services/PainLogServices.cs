using PainTrackerPT.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Services
{
    public class PainLogServices<T> : IPainLog<T> where T : class
    {
        public T GetMood(string mood)
        {
            throw new NotImplementedException();
        }

        public T GetLogDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
