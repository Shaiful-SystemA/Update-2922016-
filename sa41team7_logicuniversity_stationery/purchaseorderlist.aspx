<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="purchaseorderlist.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.purchaseorderlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Purchase Order List</h1>
                    
                    <asp:TextBox ID="tb_search" runat="server"></asp:TextBox>&nbsp;
                    <asp:Button ID="btn_search" runat="server" Text="Search" />               
                    <br />

                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>             
                </td>
            </tr>

            <tr style="display:none;">
                <td>
                    <h1>Details</h1>
                    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
