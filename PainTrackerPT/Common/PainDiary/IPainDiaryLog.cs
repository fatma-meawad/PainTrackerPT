using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.PainDiary;
namespace PainTrackerPT.Common.PainDiary
{
    interface IPainDiaryLog
    {
        PainDiaryLog GetId(int id);
        PainDiaryLog GetDescription(String description);
        PainDiaryLog GetDateTime(DateTime timeStamp);
    }
}
