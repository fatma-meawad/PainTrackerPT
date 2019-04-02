using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Interface
{
    public interface IPainDiary<T>
    {
        T GetDiaryPermission(bool permission);
        T GetPainDiaryList();
        T GetFollowUpsFromPainDiaryId(int id);
        T GetPainDiaryObject(int id);

    }
}
