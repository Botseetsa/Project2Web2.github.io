using System;
using System.Collections.Generic;

#nullable disable

namespace OrganisationWebApp.Models
{
    public partial class Record
    {
        public int RecordId { get; set; }
        public int? EmpId { get; set; }
        public int? TotalWy { get; set; }
        public int? NumOfCom { get; set; }
        public int? YearsInCurrR { get; set; }
        public int? YearsInCurrCom { get; set; }
        public int? YearsSinLastPromo { get; set; }
    }
}
