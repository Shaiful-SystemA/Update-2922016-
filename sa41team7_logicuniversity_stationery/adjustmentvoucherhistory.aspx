<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="adjustmentvoucherhistory.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.adjustmentvoucherhistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Adjustment Voucher History</h1>
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
