using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp;

namespace EmplAppSolution.Domain
{
    public class EmployeeManager
    {
        
        
        public static List<EmployeeApp.DTO.EmplFull> getEmployees()
        {
            var employees = EmployeeApp.Persistence.EmployeeRepository.getEmployees();
            return employees;
        }
        

        
        public static string[] addEmployee(EmployeeApp.DTO.Employee employee, EmployeeApp.DTO.payRateInfo payRateInfo)
        {
            string[] messageString =  new string[3];
            Guid addressGuid;
            if (employee.address != null)
            {
                addressGuid = EmployeeApp.Persistence.AddressRepository.addAddress(employee.address);
            }            
            messageString[0] = EmployeeApp.Persistence.EmployeeRepository.addEmployee(employee, payRateInfo, employee.address.Id);
            return messageString;
        }         
       
    }
}
