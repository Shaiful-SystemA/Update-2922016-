<%@ Page Title="" Language="C#" MasterPageFile="~/DeptHead_Supervisor.Master" AutoEventWireup="true" CodeBehind="approverequisitionrequests.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.depthead_supervisor.requisitionrequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Approve Requisition Requests</h1>
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
