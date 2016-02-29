<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="createpurchaseorder.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.createpurchaseorder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Create Purchase Order</h1>
                    
                    <asp:Label ID="lb_deliverto" runat="server" Text="Deliver To:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_deliverto" runat="server"></asp:TextBox>
                    <br/>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <asp:ImageButton ID="btn_catalogue" runat="server" Height="30px" ImageUrl="~/images/add_icon.png" Width="30px" PostBackUrl="~/catalogue_po.aspx" />Catalogue&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="btn_submit" runat="server" Text="Submit" />&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_clear" runat="server" Text="Clear" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
