using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Data.Doctor
{
    public interface IDataGateway<T>
    {
        IEnumerable<T> SelectAll();
        T SelectById(int? id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int? id);
        void Save();
    }
}
