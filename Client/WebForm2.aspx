<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Client.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="font-family: Arial; border: 1px solid black;">
    <tr>
        <td>
            <b>Department</b>
        </td>
        <td>
            <asp:TextBox ID="txtTitle" runat="server">
            </asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>
            <b>JobTitle</b>
        </td>
        <td>
            <asp:TextBox ID="txtdept" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <b>Hire Date</b>
        </td>
        <td>
            <asp:TextBox ID="txtHireDate" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <b>Gender</b>
        </td>
        <td>
            <asp:TextBox ID="txtGender" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <b>Date Of Birth</b>
        </td>
        <td>
            <asp:TextBox ID="txtDateOfBirth" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    
    <tr id="trHourlPay" runat="server" visible="false">
        <td>
            <b>Vacation Hours</b>
        </td>
        <td>
            <asp:TextBox ID="txtVacationHrs" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr id="trHoursWorked" runat="server" visible="false">
        <td>
            <b>Sick Leave</b>
        </td>
        <td>
            <asp:TextBox ID="txtSickLeave" runat="server">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnGetEmployee" runat="server" 
            Text="Get Employee" OnClick="btnGetEmployee_Click" />
        </td>
        <td>
            <asp:Button ID="btnSave" runat="server" 
            Text="Save Employee" OnClick="btnSave_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblMessage" runat="server" 
                ForeColor="Green" Font-Bold="true">
            </asp:Label>
        </td>
    </tr>
</table>
    </div>
    </form>
</body>
</html>
