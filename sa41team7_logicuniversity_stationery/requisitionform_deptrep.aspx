<%@ Page Title="" Language="C#" MasterPageFile="~/DeptRep.Master" AutoEventWireup="true" CodeBehind="requisitionform_deptrep.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.requisitionform_deptrep" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Requisition Form</h1>
                    
                    <asp:Label ID="lb_requisitionformnumber" runat="server" Text="Requisition Form#:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_requisitionformnumber" runat="server"></asp:TextBox>
                    <br/>
                    
                    <asp:Label ID="lb_employeename" runat="server" Text="Employee Name:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_employeename" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                    

                    <asp:Label ID="lb_urgentrequest" runat="server" Text="Urgent Request:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="cb_urgentrequest" runat="server" />
                    

                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

                    <asp:ImageButton ID="btn_catalogue" runat="server" Height="30px" ImageUrl="~/images/add_icon.png" Width="30px" PostBackUrl="~/catalogue_deptrep.aspx" />Catalogue
                    <br/>
                    <asp:Button ID="btn_submit" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
