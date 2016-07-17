<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmplOverView.aspx.cs" Inherits="EmployeeApp.Web.EmplOverView" %>

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
    <<div id="Jumbo1" class="jumbotron container-fluid">
        <h1>Employee OverView</h1>
    </div>
    <asp:Label ID="messageLabel" runat="server"></asp:Label>  <br />
    <div class="container text-left">
        <asp:Button ID="Search" runat="server" CssClass="btn btn-primary" OnClick="Search_Click" Text="Refresh Employee Information"/>
        <asp:Button ID="navToCreate" runat="server" CssClass="btn btn-primary" onClick="navToCreate_Click" Text="Create New Employee"/> 
        <br />
        <br />
        <asp:GridView ID="GV1" runat="server" class="table table-hover" OnSelectedIndexChanged="GV1_SelectedIndexChanged">
        </asp:GridView>
     </div>
    </form>
</body>
</html>
