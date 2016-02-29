<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="adjustmentvoucher.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.adjustmentvoucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Adjustment Voucher</h1>
                    <asp:Label ID="lb_vouchernumber" runat="server" Text="Voucher#:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_vouchernumber" runat="server"></asp:TextBox>
                    <br/>

                    <asp:Label ID="lb_dateissued" runat="server" Text="Date Issued:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_dateissued" runat="server"></asp:TextBox>
                    <br/>
                </td>
            </tr>

            <tr>
                <td>                    
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <asp:ImageButton ID="btn_newentry" runat="server" Height="30px" ImageUrl="~/images/add_icon.png" Width="30px" PostBackUrl="~/catalogue_emp.aspx" />Catalogue&nbsp;&nbsp;
                   
                    <asp:Button ID="btn_submit" runat="server" Text="Submit" />&nbsp;&nbsp;
                    <asp:Button ID="btn_clear" runat="server" Text="Clear" />
                </td>
            </tr>
        </table>
        </div>
</asp:Content>
