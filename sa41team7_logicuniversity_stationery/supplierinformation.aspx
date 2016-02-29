<%@ Page Title="" Language="C#" MasterPageFile="~/StoreClerk.Master" AutoEventWireup="true" CodeBehind="supplierinformation.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.supplierinformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 63px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>
                    <h1>Supplier Information</h1>
                    <asp:GridView ID="GridView1" runat="server" Height="213px" Width="411px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                        <Columns>
                            <asp:TemplateField ShowHeader="False">
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                                </ItemTemplate>
                              
                            </asp:TemplateField>

                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button ID="Button3" runat="server" CausesValidation="false" CommandName="" Text="update" />
                                </ItemTemplate>
                            </asp:TemplateField>


                                        <asp:TemplateField HeaderText="Name" HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox> 
                </EditItemTemplate> 
                <FooterTemplate> 
                    <asp:TextBox ID="txtNewName" runat="server" ></asp:TextBox> 
                </FooterTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label> 
                </ItemTemplate> 
            </asp:TemplateField> 

                        </Columns>

                    </asp:GridView>


  
                </td>
            </tr>
        </table>
    </div>
</asp:Content>


