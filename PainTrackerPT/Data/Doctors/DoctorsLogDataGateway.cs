using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Doctors;

namespace PainTrackerPT.Data.Doctors
{
    public class DoctorsLogDataGateway : IDoctorsDataGateway
    {

        public DoctorsLogDataGateway() { }
        public DoctorsLogDataGateway DLDG;

        public readonly PainTrackerPTContext db;

        public DoctorsLogDataGateway(PainTrackerPTContext sqlConnection)
        {
            db = sqlConnection;
        }

        public DoctorsLogDataGateway(DoctorsLogDataGateway _DLDG)
        {
            DLDG = _DLDG;
        }
        public bool Delete(int? id)
        {
            DoctorsLog doctorslog = db.DoctorsLog.Find(id);
            db.DoctorsLog.Remove(doctorslog);
            db.SaveChanges();
            return true;
        }

        public void Insert(DoctorsLog obj)
        {
            db.DoctorsLog.Add(obj);
            db.SaveChanges();
            return;
        }

        public void Save()
        {
            db.SaveChanges();
            return;
        }

        public IEnumerable<DoctorsLog> SelectAll()
        {
            var items = db.DoctorsLog.Select(x => new DoctorsLog {
                Id = x.Id, Description = x.Description,
                TimeStamp = x.TimeStamp });
            return items.ToList();
        }

        public DoctorsLog SelectById(int? id)
        {
            DoctorsLog doctorsLog = db.DoctorsLog.Find(id);
            return doctorsLog;
        }

        public void Update(DoctorsLog obj)
        {
            db.DoctorsLog.Update(obj);
            db.SaveChanges();
            return;
        }
    }
    
}
