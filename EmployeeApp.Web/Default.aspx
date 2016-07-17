<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmployeeApp.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.0.min.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
    <div id="Jumbo1" class="jumbotron container-fluid">
        <h1>Employee Manager</h1>
    </div>
    <asp:Label ID="messageLabel" runat="server"></asp:Label>  <br />
    <div class="container text-left">
        <h3>Enter Employee Details</h3>        
        <asp:Button ID="submitEmployee" runat="server" CssClass="btn btn-primary" OnClick="submitEmployee_Click" Text="Save Employee Information"/>
        <asp:Button ID="navToOverview" runat="server" CssClass="btn btn-primary" onClick="navToOverview_Click" Text="Employees Overview"/>        
        <br />
        <br />             
        <div class="row">
            <div class="col-sm-4">              
              <p>Employee Details</p>
                <div class="form-group">
                    <asp:Label ID="firstNameLabel" runat="server" Font-Bold="true">First Name:</asp:Label><br />
                    <asp:TextBox ID="firstNameTextBox" runat="server" class="form-control" Width="200px"></asp:TextBox><br />
                    <asp:Label ID="lastNameLabel" runat="server" Font-Bold="true">Last Name:</asp:Label><br />
                    <asp:TextBox ID="lastNameTextBox" runat="server" class="form-control" Width="200px"></asp:TextBox><br />
                    <asp:Label ID="genderLabel" runat="server" Font-Bold="true">Gender:</asp:Label><br />
                    <asp:DropDownList ID="genderDropDown" runat="server" class="form-control" Width="100px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList><br />
                </div>
            </div>
            <div class="col-sm-4">              
              <p>Employee Address</p>
                <div class="form-group">
                    <asp:Label ID="street1Label" runat="server" Font-Bold="true">Street Address:</asp:Label>
                    <asp:TextBox ID="street1TextBox" runat="server" class="form-control" Width="250px"></asp:TextBox><br />
                    <asp:Label ID="Label1" runat="server" Font-Bold="true">Street Line 2</asp:Label><br />
                    <asp:TextBox ID="street2TextBox" runat="server" class="form-control" Width="250px"></asp:TextBox><br />
                    <asp:Label ID="Label2" runat="server" Font-Bold="true">City:</asp:Label><br />
                    <asp:TextBox ID="cityTextBox" runat="server" class="form-control" Width="250px"></asp:TextBox><br />
                    <div class="form-inline">
                        <asp:Label ID="Label7" runat="server" Font-Bold="true">Province:</asp:Label>
                        <asp:TextBox ID="provTextBox" runat="server" class="form-control" Width="50px"></asp:TextBox>
                        <asp:Label ID="Label8" runat="server" Font-Bold="true">       Country:</asp:Label>
                        <asp:TextBox ID="ctryTextBox" runat="server" class="form-control" Width="50px"></asp:TextBox><br />
                    </div> <br />                    
                    <asp:Label ID="Label5" runat="server" Font-Bold="true">Postal Code:</asp:Label><br />
                    <asp:TextBox ID="pCodeTextBox" runat="server" class="form-control" Width="100px"></asp:TextBox><br />
                    <asp:Label ID="Label6" runat="server" Font-Bold="true">Notes</asp:Label><br />
                    <asp:TextBox ID="notesTextBox" runat="server" class="form-control" Width="250px" Height="100px"></asp:TextBox><br />

                </div>
            </div>
            <div class="col-sm-4">              
              <p>Payroll Information</p>                
                    <div class="form-group">
                        <asp:Label ID="dailyWorkHoursLabel" class="control-label col-sm-6" runat="server" Font-Bold="true">Daily Work Hours</asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="dlyWorkHrsText" runat="server" class="form-control" Width="100px"></asp:TextBox>
                        </div>                        
                    </div><br />
                    <div class="form-group">
                        <asp:Label ID="weeklyWorjHoursLabel" class="control-label col-sm-6" runat="server" Font-Bold="true">Weekly Work Hours</asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="weekyHoursTextBox" runat="server" class="form-control" Width="100px"></asp:TextBox>
                        </div>       
                    </div><br />
                    <div class="form-group">
                        <asp:Label ID="payRateLabel" class="control-label col-sm-6" runat="server" Font-Bold="true">Pay Rate</asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="payRateText" runat="server" class="form-control" Width="100px"></asp:TextBox>
                        </div>       
                    </div><br />
                    <div class="form-group">
                        <asp:Label ID="otFactorLabel" class="control-label col-sm-6" runat="server" Font-Bold="true">OverTime Factor</asp:Label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="otDropDownList" runat="server" class="form-control" Width="100px">
                                <asp:ListItem>1X</asp:ListItem>
                             <asp:ListItem>1.5X</asp:ListItem>
                             <asp:ListItem>2.0X</asp:ListItem>
                            </asp:DropDownList><br />
                         </div>
                    </div><br />
                    
                    <div class="form-group">
                        <br /><br /><br /><br /><br /><br />
                        <asp:Label ID="notesLabel2" class="control-label col-sm-6" runat="server" Font-Bold="true">Payroll Notes</asp:Label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="notesTextBox2" runat="server" class="form-control" Width="250px" Height="100px"></asp:TextBox>
                        </div>  
                    </div>               
            </div>  
       
        </div> 
                   
    </div>
  </div>

</div>        
    </form>      
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/test.js"></script>
</body>
</html>
