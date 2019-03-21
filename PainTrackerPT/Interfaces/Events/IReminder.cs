using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingEvents.Interfaces
{
    interface IReminder<T> where T : class
    {
        void setReminder(T e);
    }
}
