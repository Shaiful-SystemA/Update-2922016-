<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="retrievallist.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.retrievallist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Retrieval List</h1>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <asp:Button ID="btn_save" runat="server" Text="Save" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
