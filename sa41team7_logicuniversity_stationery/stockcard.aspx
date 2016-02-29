<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="stockcard.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.stockcard1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Stock Card</h1>
                    
                    <asp:Label ID="lb_itemcode" runat="server" Text="Item Code:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_itemcode" runat="server"></asp:TextBox>

                    <br/>
                    <asp:Label ID="lb_itemdescription" runat="server" Text="Item Description:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_itemdescription" runat="server"></asp:TextBox>

                    <br/>
                    <asp:Label ID="lb_binnumber" runat="server" Text="Bin#:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_binnumber" runat="server"></asp:TextBox>

                    <br/>
                    <asp:Label ID="lb_uom" runat="server" Text="UOM:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_uom" runat="server"></asp:TextBox>

                    <br/>
                    <asp:Label ID="lb_suppliers" runat="server" Text="Suppliers:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_suppliers" runat="server"></asp:TextBox>

                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <asp:Button ID="btn_back" runat="server" Text="Back" PostBackUrl="~/catalogue_storeclerk.aspx" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
