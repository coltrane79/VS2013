using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp;

namespace EmployeeApp.Persistence
{
    public class PayInfoRepository
    {
        public static string addPayRateInfo(DTO.payRateInfo payRateInfo)
        {
            
            EmployeeApp.Persistence.EmployeesEntities db = new EmployeeApp.Persistence.EmployeesEntities();
            var RateInfo = db.EmplyPayInfoes;

            EmployeeApp.Persistence.EmplyPayInfo newRateInfo = new EmployeeApp.Persistence.EmplyPayInfo();
            newRateInfo.pernr = payRateInfo.pernr;
            newRateInfo.datefrom = DateTime.Today;
            newRateInfo.dateto = new DateTime(9999, 12, 31);
            newRateInfo.dailyWorkHours = payRateInfo.dailyWorkHours;
            newRateInfo.weeklyWorkHours = payRateInfo.weeklyWorkHours;
            newRateInfo.payRate = payRateInfo.payRate;
            newRateInfo.overtimefactor = payRateInfo.overtimefactor;
            newRateInfo.Notes = payRateInfo.Notes;

            string msg = "";
            try
            {
                RateInfo.Add(newRateInfo);
                db.SaveChanges();
                msg = "Rate Information Saved";
                return msg;
            }
            catch (Exception ex)
            {
                msg = ex.InnerException.ToString();
                return msg;
                //throw;
            }            

        }
    }
}
