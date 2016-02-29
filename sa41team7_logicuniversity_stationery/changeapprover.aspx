<%@ Page Title="" Language="C#" MasterPageFile="~/DeptHead_Supervisor.Master" AutoEventWireup="true" CodeBehind="changeapprover.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.approver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Change Approver</h1>
                    
                    <asp:Label ID="lb_currentapprover" runat="server" Text="Current Approver:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_currentapprover" runat="server"></asp:TextBox>
                    <br/><br/>
                    
                    <asp:Label ID="lb_newapprover" runat="server" Text="New Approver:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_newapprover" runat="server"></asp:DropDownList><br/><br/>
                   
                    <asp:Label ID="lb_periodfrom" runat="server" Text="Period From:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_periodfrom" runat="server"></asp:TextBox>
                    <asp:Calendar ID="cal_periodfrom" runat="server"></asp:Calendar>
                    <br/><br/>

                    <asp:Label ID="lb_periodto" runat="server" Text="Period To (optional):"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_periodto" runat="server"></asp:TextBox>
                    <asp:Calendar ID="cal_periodto" runat="server"></asp:Calendar>
                    <br/><br/>

                    <asp:Button ID="btn_update" runat="server" Text="Update" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
