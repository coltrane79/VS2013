using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DTO
{
    public class payRateInfo
    {
        public System.Guid pernr { get; set; }
        public System.DateTime datefrom { get; set; }
        public System.DateTime dateto { get; set; }
        public Nullable<decimal> dailyWorkHours { get; set; }
        public Nullable<decimal> weeklyWorkHours { get; set; }
        public Nullable<decimal> payRate { get; set; }
        public string overtimefactor { get; set; }
        public string Notes { get; set; }
    }
}
