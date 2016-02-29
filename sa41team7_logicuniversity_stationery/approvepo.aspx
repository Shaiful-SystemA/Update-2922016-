<%@ Page Title="" Language="C#" MasterPageFile="~/StoreManager_Supervisor.Master" AutoEventWireup="true" CodeBehind="approvepo.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.approvepo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Approve PO</h1>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </td>
            </tr>

            <tr style="display:none;">
                <td>
                    <h1>Details</h1>                    
                    
                    <asp:Label ID="lb_clerkname" runat="server" Text="Clerk Name:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_clerkname" runat="server"></asp:TextBox>

                    <br/>
                    <asp:Label ID="lb_contactno" runat="server" Text="Contact No:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_contactno" runat="server"></asp:TextBox>

                    <br/>
                    <asp:Label ID="lb_deliverto" runat="server" Text="Deliver To:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_deliverto" runat="server"></asp:TextBox>
                    
                    <br/>
                    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                </td>
            </tr>

        </table>
    </div>
</asp:Content>
