<%@ Page Title="" Language="C#" MasterPageFile="~/StoreManager_Supervisor.Master" AutoEventWireup="true" CodeBehind="trendreports.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.trendreport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Trend Report</h1>
                    <asp:Label ID="lb_reporttype" runat="server" Text="Report Type:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </td>
            </tr>

            <tr id="byrequisitionrequest" style="display:none;">
                <td>
                    <asp:Label ID="lb_selectfirstmonth" runat="server" Text="Select First Month:"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_firstmonth" runat="server"></asp:DropDownList>

                    <<asp:Label ID="lb_selectsecondmonth" runat="server" Text="Select Second Month (optional):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_secondmonth" runat="server"></asp:DropDownList>

                    <asp:Label ID="lb_selectthirdmonth" runat="server" Text="Select Third Month (optional):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_thirdmonth" runat="server"></asp:DropDownList>
                    <br/>

                    <asp:Label ID="lb_selectdepartment" runat="server" Text="Select Dept (choose ALL or any 1 department):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_department" runat="server"></asp:DropDownList>

                    <asp:Label ID="lb_selectcategory" runat="server" Text="Select Category (choose ALL or any 1 category):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_category" runat="server"></asp:DropDownList>
                    
                    <br/>                    
                    <asp:Button ID="btn_generatebyrequisitionrequest" runat="server" Text="Generate" />                    
                </td>
            </tr>

            <tr id="byorders" style="display:none;">
                <td>
                    <asp:Label ID="lb_selectfirstmth" runat="server" Text="Select First Month:"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_firstmth" runat="server"></asp:DropDownList>

                    <<asp:Label ID="lb_selectsecondmth" runat="server" Text="Select Second Month (optional):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_secondmth" runat="server"></asp:DropDownList>

                    <asp:Label ID="lb_selectthirdmth" runat="server" Text="Select Third Month (optional):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_thirdmth" runat="server"></asp:DropDownList>
                    <br/>

                    <asp:Label ID="lb_selectsupp" runat="server" Text="Select Supplier (choose ALL or any 1 supplier):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_supp" runat="server"></asp:DropDownList>

                    <asp:Label ID="lb_selectcat" runat="server" Text="Select Category (choose ALL or any 1 category):"></asp:Label>&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_cat" runat="server"></asp:DropDownList>
                    
                    <br/>                    
                    <asp:Button ID="btn_generatebyorders" runat="server" Text="Generate" />                    
                </td>
            </tr>

            <tr style="display:none;">
                <td>
                    &nbsp;</td>
            </tr>

            <tr style="display:none;">
                <td>
                    &nbsp;</td>
            </tr>

            <tr style="display:none;">
                <td>
                    &nbsp;</td>
            </tr>

            <tr style="display:none;">
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
