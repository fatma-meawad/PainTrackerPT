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
        public Guid medGuid { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        public String Img { get; set; }        
    }
}
