using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.PainDiary;
using PainTrackerPT.Data.PainDiary;

namespace PainTrackerPT.Services.PainDiary
{
    public class PainDiaryLogService : IPainDiaryLogService
    {

        UnitOfWork uow = new UnitOfWork();

        public IEnumerable<PainDiaryLog> Get()
        {
            return uow.PDLRepository.Get();
        }

        public PainDiaryLog GetByID(int? id)
        {
            return uow.PDLRepository.GetByID(id);
        }

        public void Insert(PainDiaryLog obj)
        {
            uow.PDLRepository.Insert(obj);
            uow.Save();
            return;

        }

        public void Delete(int? id)
        {
            uow.PDLRepository.Delete(id);
            uow.Save();
            return;
        }

        public void Update(PainDiaryLog obj)
        {
            uow.PDLRepository.Update(obj);
            uow.Save();
            return;
        }

        
    }
}
