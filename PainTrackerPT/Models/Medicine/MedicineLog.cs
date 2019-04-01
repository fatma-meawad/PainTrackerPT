using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PainTrackerPT.Models.Medicine
{
    public class MedicineLog
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }        
        public Guid MedGuid { get; set; }

    }
}
