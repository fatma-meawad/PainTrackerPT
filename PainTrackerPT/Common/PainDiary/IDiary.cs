using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.PainDiary;

namespace PainTrackerPT.Common.PainDiary
{
    interface IDiary
    {

        void GetDiaryPermission(bool permission);
        void GetPainDiaryList();
        void GetFollowUpsFromPainDiaryId(int id);
        void GetPainDiaryObject(int id);
    }
}
