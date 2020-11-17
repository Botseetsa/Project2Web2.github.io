using System;
using System.Collections.Generic;

#nullable disable

namespace OrganisationWebApp.Models
{
    public partial class Department
    {
        public int DepId { get; set; }
        public int? EmpId { get; set; }
        public string DepType { get; set; }
        public string BusinessT { get; set; }
        public int? JobL { get; set; }
        public string JobR { get; set; }
    }
}
