using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DTO
{
    public class Employee
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string fullName { get; private set; }
        public string gender { get; private set; }
        public Address address { get; set; }

        public Employee(string firstName, string lastName, string gender, Address address = null )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = lastName + firstName;
            this.gender = gender;
            this.address = address;
        }
    }

    
}
