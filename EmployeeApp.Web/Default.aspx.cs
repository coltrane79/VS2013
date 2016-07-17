using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeApp;
using System.Text;

namespace EmployeeApp.Web
{
    public partial class Default : System.Web.UI.Page
    {

        /*Constants used for boostrap messages*/
        const string _alertSuccess = "alert alert-success";
        const string _alertInfo = "alert alert-info";
        const string _alertWarning = "alert alert-warning";
        const string _alertDanger = "alert alert-danger";                
        
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Adds a jQuery event to fade out via ClientSript Object
             * that fades out the message return on an action.
             * ensure that jQuery is loaded @ top of page, or at 
             * least until I can figure out the proper event to keep script loading
             * at bottom of page: Event LifeCycle Link https://msdn.microsoft.com/en-us/library/ms178472.aspx
             */  
            String csName = "LabelFadeScript";
            Type csType = this.GetType();

            ClientScriptManager cs = Page.ClientScript;

            if (!cs.IsClientScriptBlockRegistered(csType, csName))
            {
                StringBuilder csText = new StringBuilder();
                csText.Append("<script type=\"text/javascript\">");
                csText.Append("$(document).ready(function () { $('#messageLabel').delay(2000).fadeOut(2000); })");
                csText.Append("</script>");
                cs.RegisterClientScriptBlock(csType, csName, csText.ToString());
            }      
        }

        /*
         * Handles the transfer to OverView Page
         */
        protected void navToOverview_Click(object sender, EventArgs e)
        {
            Server.Transfer("EmplOverView.aspx");
        }
        

        /*
         * Handles the submit button event
         */
        protected void submitEmployee_Click(object sender, EventArgs e)
        {            
            
            if(firstNameTextBox.Text.Trim() != String.Empty && lastNameTextBox.Text.Trim() != String.Empty
                && genderDropDown.Text.Trim() != String.Empty)
            {
                DTO.Employee employee = getEmplData();
                DTO.payRateInfo payRateInfo = getPayRateInfo();
                createEmployee(employee, payRateInfo);                
            }
            else
            {
                messageLabel.Text = getMessage(_alertDanger, "Enter all Information for Employee");
            }                
        }

        /*
         * Uses a stringbuilder function to generate html
         * div tag for a bootstrap alert class
         */
        private string getMessage(string msgType, string msg)
        {
                StringBuilder sb = new StringBuilder();
                sb.Append("<div class=\"");
                sb.Append(msgType);
                sb.Append(" fade in  \">");
                sb.Append("<a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>");
                sb.Append("<strong>");
                sb.Append(msg);
                sb.Append("</strong></div>");
                return sb.ToString();
        }

        /*
         * Returns the Employee Information from the employee Form
         */
        private DTO.Employee getEmplData()
        {
            DTO.Employee employee = new DTO.Employee(
                  firstNameTextBox.Text.Trim(),
                  lastNameTextBox.Text.Trim(),
                  genderDropDown.Text);
            employee.address = getAddressData();
            return employee;
        }

        /*
         * Submits new Employee to be committed to Database
         * and supplies boostrap messages to the message are
         * in the form
         */
        private void createEmployee(DTO.Employee employee, DTO.payRateInfo payRateInfo)
        {
            string[] messageString = new string[1];
            messageString = EmplAppSolution.Domain.EmployeeManager.addEmployee(employee, payRateInfo);

            if (messageString[0] == "Rate Information Saved & Employee Entered Successfully!")
                messageLabel.Text = getMessage(_alertSuccess, messageString[0]);
            else
                messageLabel.Text = getMessage(_alertDanger, messageString[0]);
        }

        /*
         * Returns the Adress Information from the address Form
         */
        private DTO.Address getAddressData()
        {            
            DTO.Address address = new DTO.Address(
                street1TextBox.Text.Trim(),
                street2TextBox.Text.Trim(),
                cityTextBox.Text.Trim(),
                ctryTextBox.Text.Trim(),
                provTextBox.Text.Trim(),
                pCodeTextBox.Text.Trim(),
                notesTextBox.Text.Trim()
                );
            return address;
        }

        private DTO.payRateInfo getPayRateInfo()
        {
            double dlyHours = 0.00;
            double wklyHours = 0.00;
            double payRate = 0.00;

            Double.TryParse(dlyWorkHrsText.Text.Trim(), out dlyHours);
            Double.TryParse(weekyHoursTextBox.Text.Trim(), out wklyHours);
            Double.TryParse(payRateText.Text.Trim(), out payRate);

            DTO.payRateInfo payRateInfo = new DTO.payRateInfo { 
                pernr = Guid.NewGuid(),
                datefrom = DateTime.Now,
                dateto = new DateTime(9999,12,31),
                dailyWorkHours = (decimal)dlyHours,
                weeklyWorkHours = (decimal)wklyHours,
                payRate = (decimal)payRate,
                overtimefactor = otDropDownList.Text.Trim(),
                Notes = notesTextBox2.Text.Trim()                               
            };
            return payRateInfo;
        }

        
        
    }
}