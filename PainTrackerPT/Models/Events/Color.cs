using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrackingEvents.Models
{
    public class Color
    {
        [Required]
        public int Id { get; set; }
        public string colorName { get; set; }
        public string colorCode { get; set; }
        public string colorDesc { get; set; }
    }
}
