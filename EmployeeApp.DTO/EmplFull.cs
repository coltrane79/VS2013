using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DTO
{
    public class EmplFull
    {
        public System.Guid pernr { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public Nullable<decimal> dailyWorkHours { get; set; }
        public Nullable<decimal> weeklyWorkHours { get; set; }
        public Nullable<decimal> payRate { get; set; }
        public string overtimefactor { get; set; }
    }
}
