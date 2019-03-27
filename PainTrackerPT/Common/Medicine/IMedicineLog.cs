﻿using PainTrackerPT.Models.Medicine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Medicine
{
    public interface IMedicineLog<T>
    {
        T GetLogAt(DateTime dt);
        T GetLogFromTo(DateTime start_dt, DateTime end_dt);
        IEnumerable<T> SelectAll();
        void Insert(T obj);
        T SelectById(int? id);
        void Update(T obj);
        void Delete(int? id);
    }
}
