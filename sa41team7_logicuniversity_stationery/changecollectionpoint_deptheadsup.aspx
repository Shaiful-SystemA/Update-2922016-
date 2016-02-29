<%@ Page Title="" Language="C#" MasterPageFile="~/DeptHead_Supervisor.Master" AutoEventWireup="true" CodeBehind="changecollectionpoint_deptheadsup.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.collectionpoint1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Change Collection Point</h1>
                    
                    <asp:Label ID="lb_currentcollectionpoint" runat="server" Text="Current Collection Point:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tb_currentcollectionpoint" runat="server"></asp:TextBox>
                    <br/><br/>
                    
                    <asp:Label ID="lb_newcollectionpoint" runat="server" Text="New Collection Point:"></asp:Label><br/>

                    <asp:RadioButton ID="rb_stationerystore" runat="server" />&nbsp;&nbsp; Stationery Store Administration Building (9.30am)<br/>
                    <asp:RadioButton ID="rb_managementschool" runat="server" />&nbsp;&nbsp; Management School (11.00am)<br/>
                    <asp:RadioButton ID="rb_medicalschool" runat="server" />&nbsp;&nbsp; Medical School (11.00am)<br/>
                    <asp:RadioButton ID="rb_engineeringschool" runat="server" />&nbsp;&nbsp; Engineering School (11.00am)<br/>
                    <asp:RadioButton ID="rb_scienceschool" runat="server" />&nbsp;&nbsp; Science School (9.30am)<br/>
                    <asp:RadioButton ID="rb_universityhospital" runat="server" />&nbsp;&nbsp; University Hospital (11.00am)<br/><br/>

                    <asp:Button ID="btn_update" runat="server" Text="Update" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
