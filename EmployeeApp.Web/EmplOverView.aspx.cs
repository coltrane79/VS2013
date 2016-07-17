using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeApp.Web
{
    public partial class EmplOverView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DTO.EmplFull> emplList = EmplAppSolution.Domain.EmployeeManager.getEmployees();
            GV1.DataSource = emplList.ToList();
            GV1.DataBind();
        }

        protected void Search_Click(object sender, EventArgs e)
        {

        }

        protected void navToCreate_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx");
        }

        protected void GV1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}