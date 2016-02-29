<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="disbursementlist.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.disbursementlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Disbursement List</h1>
                    
                    <asp:Label ID="lb_dept" runat="server" Text="Department: "></asp:Label>
                    <asp:DropDownList ID="dd_department" runat="server"></asp:DropDownList>
                    
                    <asp:Label ID="lb_collectionpoint" runat="server" Text="Collection Point: "></asp:Label>
                    <asp:DropDownList ID="dd_collectionpoint" runat="server"></asp:DropDownList>                 
                    <br />

                    <asp:Label ID="lb_datetocollect" runat="server" Text="Date To Collect: "></asp:Label>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

                    <asp:Label ID="lb_status" runat="server" Text="Status: "></asp:Label>
                    <asp:DropDownList ID="dd_status" runat="server"></asp:DropDownList>                 
                    <br />

                   <asp:Button ID="btn_search" runat="server" Text="Search" />  
                </td>
            </tr>

            <tr style="display:none;">
                <td>                    
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    <asp:Button ID="btn_selectall" runat="server" Text="Select All" />  
                    <asp:Button ID="btn_notify" runat="server" Text="Notify" />  
                </td>
            </tr>

        </table>
    </div>
</asp:Content>
