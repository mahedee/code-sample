<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportParameter.aspx.cs" Inherits="ReportParameter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Branch: </td>
                    <td>
                        <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gender: </td>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnViewReport" Text="View Report" runat="server" OnClick="btnViewReport_Click" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
