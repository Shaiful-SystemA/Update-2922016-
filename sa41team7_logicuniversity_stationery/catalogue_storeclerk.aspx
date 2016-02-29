<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="catalogue_storeclerk.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.catalogue_storeclerk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Catalogue</h1>
                    
                    <asp:TextBox ID="tb_search" runat="server"></asp:TextBox>&nbsp;
                    <asp:Button ID="btn_search" runat="server" Text="Search" />               
                    <br />

                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <asp:Button ID="btn_selectall" runat="server" Text="Select All" />&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_addtorequestlist" runat="server" Text="Add to Request List" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
