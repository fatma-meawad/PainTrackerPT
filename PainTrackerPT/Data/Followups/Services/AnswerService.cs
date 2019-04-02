
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Common.Followups;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Data.Followups.Services;

namespace PainTrackerPT.Data.Followups
{
    public class AnswerService : BaseService <Answer>
    {
        // TODO: DI THIS
        public AnswerService(IBaseRepository<Answer> baseRepository) : base(baseRepository)
        {
        }
        public async Task<IEnumerable<Answer>> SelectAllByFollowUpId(Int64 questionId)
        {
            return await ((AnswerRepository)_baseRepository).SelectAllByQuestionId(questionId);
        }
    }
}
