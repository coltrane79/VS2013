using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp;

namespace EmployeeApp.Persistence
{
    public class EmployeeRepository
    {

        public static string addEmployee(DTO.Employee employee, DTO.payRateInfo payRateInfo, Guid addressGuid = new Guid())
        {
            EmployeesEntities db = new EmployeesEntities();
            var employees = db.Employees;

           Persistence.Employee newEmployee = new Persistence.Employee();

           newEmployee.pernr = Guid.NewGuid();
           newEmployee.firstName = employee.firstName;
           newEmployee.lastName = employee.lastName;
           newEmployee.fullName = employee.fullName;
           newEmployee.gender = employee.gender;
           
            if(employee.address != null)
               newEmployee.address = addressGuid;
           
           string messageString = "";
           try
           {
               employees.Add(newEmployee);
               db.SaveChanges();
               payRateInfo.pernr = newEmployee.pernr;
               try
               {
                   messageString = EmployeeApp.Persistence.PayInfoRepository.addPayRateInfo(payRateInfo);
                   messageString += " & ";
               }
               catch (Exception ex)
               {
                   messageString = String.Format("Error in updating Pay Rate Information: {0}", ex.InnerException.ToString());
                   //throw;
                   
               }
               messageString += "Employee Entered Successfully!";
                   return messageString;
           }
           catch (Exception ex)
           {
               messageString = String.Format("Error updating Database:{0}", ex.Message);
               return messageString;
               //throw;
           }           
        }

        
        public static List<DTO.EmplFull> getEmployees()
        {

            Persistence.EmployeesEntities db = new EmployeesEntities();
            var employees = db.Employees;
            var emplRateInfo = db.EmplyPayInfoes;

            List<DTO.EmplFull> emplList = new List<DTO.EmplFull>();

            foreach (var employee in employees)
            {
                DTO.EmplFull fullEmpl = new DTO.EmplFull();

                fullEmpl.pernr = employee.pernr;
                fullEmpl.firstName = employee.firstName;
                fullEmpl.lastName = employee.lastName;
                fullEmpl.fullName = employee.fullName;
                fullEmpl.gender = employee.gender;
                var payQuery = emplRateInfo.Where(r => r.pernr == fullEmpl.pernr);     
                Persistence.EmplyPayInfo payInfo = payQuery.FirstOrDefault();
                
                if (payQuery != null)
                {
                    fullEmpl.dailyWorkHours = payInfo.dailyWorkHours;
                    fullEmpl.weeklyWorkHours = payInfo.weeklyWorkHours;
                    fullEmpl.payRate = payInfo.payRate;
                    fullEmpl.overtimefactor = payInfo.overtimefactor;
                }

                emplList.Add(fullEmpl);
            };

            return emplList;
        }
        
    }
}
