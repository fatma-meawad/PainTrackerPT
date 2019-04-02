using PainTrackerPT.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Services
{
    public class PainDiaryService<T> : IPainDiary<T> where T : class
    {
       
        public T GetDiaryPermission(bool permission)
        {
            throw new NotImplementedException();
        }

        public T GetFollowUpsFromPainDiaryId(int id)
        {
            throw new NotImplementedException();
        }

        public T GetPainDiaryList()
        {
            throw new NotImplementedException();
        }

        public T GetPainDiaryObject(int id)
        {
            throw new NotImplementedException();
        }
    }
}
