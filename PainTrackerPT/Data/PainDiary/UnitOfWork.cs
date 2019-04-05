using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models;
using PainTrackerPT.Models.PainDiary;

namespace PainTrackerPT.Data.PainDiary
{
    public class UnitOfWork
    {
        private PainTrackerPTContext context = new PainTrackerPTContext();
        
        private GenericRepository<PainDiaryLog> pdlRepository;

        public GenericRepository<PainDiaryLog> PDLRepository
        {
            get
            {
                if (this.pdlRepository == null)
                {
                    this.pdlRepository = new GenericRepository<PainDiaryLog>(context);
                }
                return pdlRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }


    }
}
