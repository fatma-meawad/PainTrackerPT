using PainTrackerPT.Models.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Services.Doctors
{
    public interface IDoctorsLogServices
    {
        IEnumerable<DoctorsLog> SelectAll();
        DoctorsLog SelectById(int? id);
        void Insert(DoctorsLog obj);
        void Update(DoctorsLog obj);
        Boolean Delete(int? id);
        void Save();
    }
}
