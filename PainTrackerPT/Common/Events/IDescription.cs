using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingEvents.Interfaces
{
    // <T> means any object type
    interface IDescription<T> where T:class
    {
        void setDescription(T e, String desc);
    }
}
