using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplAppSolution.Domain
{
    public class Employee
    {        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public Address address { get; set; }
    }
}
