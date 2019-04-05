using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.PainDiary;

namespace PainTrackerPT.Services.PainDiary
{
    interface IPainDiaryLogService
    {
        IEnumerable<PainDiaryLog> Get();
        PainDiaryLog GetByID(int? id);
        void Insert(PainDiaryLog obj);
        void Delete(int? id);
        void Update(PainDiaryLog obj);
    }
}
