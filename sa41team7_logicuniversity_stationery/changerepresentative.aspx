<%@ Page Title="" Language="C#" MasterPageFile="~/DeptHead_Supervisor.Master" AutoEventWireup="true" CodeBehind="changerepresentative.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.representative" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Change Representative</h1>
                    
                    <asp:Label ID="lb_currentrepresentative" runat="server" Text="Current Representative:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_currentrepresentative" runat="server"></asp:TextBox>
                    <br/><br/>
                    
                    <asp:Label ID="lb_newrepresentative" runat="server" Text="New Representative:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dd_newrepresentative" runat="server"></asp:DropDownList><br/><br/>
                   
                    <asp:Button ID="btn_update" runat="server" Text="Update" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
