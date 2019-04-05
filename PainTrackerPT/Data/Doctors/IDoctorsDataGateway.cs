using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Doctors;

namespace PainTrackerPT.Data.Doctors
{
    public interface IDoctorsDataGateway
    {
        IEnumerable<DoctorsLog> SelectAll();
        DoctorsLog SelectById(int? id);
        void Insert(DoctorsLog obj);
        void Update(DoctorsLog obj);
        Boolean Delete(int? id);
        void Save();
    }
}
