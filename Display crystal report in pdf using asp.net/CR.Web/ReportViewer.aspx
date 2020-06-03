<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportViewer.aspx.cs" Inherits="ReportViewer" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

<%--            <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />--%>

    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/4_0_30319/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
       <tr>
      <td style="height: 6px">
     <%--     &nbsp;<LS_UI:Leadsoft_ButtonClass ID="Ls_Btn2" runat="server" Height="20px" OnClick="Leadsoft_ButtonClass1_Click"
              Text="Back" Width="88px" AccessKey="B" />&nbsp;--%>
          </td>
       </tr>
      <tr>
        <td><div>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" HasPrintButton="True" HasRefreshButton="True" ReuseParameterValuesOnRefresh="True" Height="50px" Width="350px" OnReportRefresh="CrystalReportViewer1_ReportRefresh" PrintMode="ActiveX" />
            &nbsp; &nbsp;
            &nbsp; &nbsp;</div>
    </td>
    </tr>
     <tr>
      <td style="height: 26px">
          <%--&nbsp;<LS_UI:Leadsoft_ButtonClass ID="Ls_Btn1" runat="server" Height="19px" OnClick="Leadsoft_ButtonClass2_Click"
              Text="Back" Width="86px" Visible="False" /></td>--%>
       </tr>
    </table>

    </div>
    </form>
</body>
</html>
