using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PainTrackerPT.Models.Followups
{
    public class Question : BaseEntity
    {
        private String Description { get => Description; set => Description = value; }
        private DateTime DateGenerated { get => DateGenerated; set => DateGenerated = value; }
    }
}
