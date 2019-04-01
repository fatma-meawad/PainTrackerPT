using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Data.Followups
{
    public class FollowUpRepository : BaseRepository<FollowUp>
    {
        public FollowUpRepository(PainTrackerPTContext db) : base(db){}
    
        public async Task<IEnumerable<FollowUp>> SelectAllByDoctorId(Int64 doctorId)
        {
            return await _dbSet.Where(q => q.DoctorId == doctorId).ToListAsync();
        }

        public async Task<IEnumerable<FollowUp>> SelectAllByPatientId(Int64 patientId)
        {
            return await _dbSet.Where(q => q.PatientId == patientId).ToListAsync();
        }
    }
}