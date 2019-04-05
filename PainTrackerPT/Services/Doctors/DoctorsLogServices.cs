using PainTrackerPT.Common.Doctors;
using PainTrackerPT.Data.Doctors;
using PainTrackerPT.Models.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Services.Doctors
{
    public class DoctorsLogServices : IDoctorsLog, IDoctorsLogServices
    {
        private readonly IDoctorsDataGateway _doctorsDataGateway;

        public DoctorsLogServices() { }

        public DoctorsLogServices(IDoctorsDataGateway doctorsDataGateway)
        {
            _doctorsDataGateway = doctorsDataGateway;
        }

        public void Insert(DoctorsLog obj)
        {
            _doctorsDataGateway.Insert(obj);
        }

        public bool Delete(int? id)
        {
            return _doctorsDataGateway.Delete(id);
        }
        public void Save()
        {
            _doctorsDataGateway.Save();
        }

        public IEnumerable<DoctorsLog> SelectAll()
        {
            return _doctorsDataGateway.SelectAll();
        }

        public DoctorsLog SelectById(int? id)
        {
            return _doctorsDataGateway.SelectById(id);
        }

        public void Update(DoctorsLog obj)
        {
            _doctorsDataGateway.Update(obj);
        }


        public DoctorsLog GetLogAt(DateTime dt)
        {
            return null;
        }

        public DoctorsLog GetLogFromTo(DateTime start_dt, DateTime end_dt)
        {
            return null;
        }
    }
}
