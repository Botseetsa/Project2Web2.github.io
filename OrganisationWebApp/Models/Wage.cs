using System;
using System.Collections.Generic;

#nullable disable

namespace OrganisationWebApp.Models
{
    public partial class Wage
    {
        public int WageId { get; set; }
        public int? EmpId { get; set; }
        public string HourlyRate { get; set; }
        public string MonthlyIncome { get; set; }
        public string OverTime { get; set; }
    }
}
