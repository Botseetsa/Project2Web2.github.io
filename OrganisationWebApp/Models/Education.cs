using System;
using System.Collections.Generic;

#nullable disable

namespace OrganisationWebApp.Models
{
    public partial class Education
    {
        public int EduId { get; set; }
        public int? EmpId { get; set; }
        public int? EduYears { get; set; }
        public string EduField { get; set; }
    }
}
