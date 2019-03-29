using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;


namespace PainTrackerPT.Common.Followups
{
    public interface IAdviceService
    {
        void CreateNewAdvice(Advice advice);
        void UpdateAdvice(Guid id, Advice advice);
        void DeleteAdvice(Guid id);
        Task<Advice> Select(Guid id);
        Task<IEnumerable<Advice>> SelectAll();
    }
}
