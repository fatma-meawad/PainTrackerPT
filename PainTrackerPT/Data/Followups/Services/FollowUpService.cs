
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
using PainTrackerPT.Data.Followups.Services;
using PainTrackerPT.Data.Followups.Repository;

namespace PainTrackerPT.Data.Followups.Services
{
    public class FollowUpService : BaseService <FollowUp>, IFollowUpService
    {
        public FollowUpService(IBaseRepository<FollowUp> fup): base(fup) {
        }

        public async Task<IEnumerable<FollowUp>> SelectAllByDoctorId(Int64 doctorId)
        {
            return await ((FollowUpRepository)_baseRepository).SelectAllByDoctorId(doctorId);
        }

        public async Task<IEnumerable<FollowUp>> SelectAllByPatientId(Int64 patientId)
        {
            return await ((FollowUpRepository)_baseRepository).SelectAllByPatientId(patientId);
        }
    }
}
