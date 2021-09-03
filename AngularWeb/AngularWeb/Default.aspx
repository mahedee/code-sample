<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AngularWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" ng-controller="studentsCtrl" ng-app="app">

        <table class="table table-striped table-hover table-condensed">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Credit</th>
                    <th>Semester</th>

                </tr>
            </thead>

            <tr ng-repeat="student in studentInfo">
                <td>{{student.id}}
                </td>
                <td>{{student.name}}
                </td>
                <td>{{student.credit}}
                </td>
                <td>{{student.semester}}
                </td>
            </tr>
        </table>


    </div>
</asp:Content>
