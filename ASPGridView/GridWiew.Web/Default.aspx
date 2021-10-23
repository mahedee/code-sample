<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        Employee Information
        <br />
        Md. Mahedee Hasan
    </p>
    <br />
    <table>
        <tr>
            <td align="right">
                Full Name :
            </td>
            <td>
                <asp:TextBox ID="txtEmpFullNm" Width ="200px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Nick Name :
            </td>
            <td>
                <asp:TextBox ID="txtEmpNickNm" Width ="200px" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td align="right">
                Designation :
            </td>
            <td>
                <asp:TextBox ID="txtDesignation" runat="server"
                    Width="200px"></asp:TextBox>
            </td>
        </tr>
    </table>

    <asp:Button ID = "btnSave" runat = "server" Text ="Save" Height="23px" 
        style="font-weight: 700" Width="100px" onclick="btnSave_Click" />

        <asp:HiddenField ID ="hf_emp_gid" runat ="server" />
    <br />
    <br />
    <asp:GridView ID="gvEmpInfo" runat="server" AutoGenerateColumns="False" CellPadding="4"
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="emp_fullnm" HeaderText="Full Name" />
            <asp:BoundField DataField="emp_nicknm" HeaderText="Nick Name" />
            <asp:BoundField DataField="emp_designation" HeaderText="Designation" />
            <asp:TemplateField HeaderText="Edit">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                <ItemTemplate>
                    <asp:HiddenField ID="hidemp_gid" runat="server" Value='<%#Eval("emp_gid") %>' />
                    <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CausesValidation="false"
                        RowIndex='<%# Container.DisplayIndex %>' OnClick="btnEdit_Click">
                            <img style="border:none;" src = "Images/edit_icon.gif"/></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                <ItemTemplate>
                    <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CausesValidation="false"
                        RowIndex='<%# Container.DisplayIndex %>' OnClick="btnDelete_Click">
                            <img style="border:none;" src = "Images/icon_remove.png"/></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
