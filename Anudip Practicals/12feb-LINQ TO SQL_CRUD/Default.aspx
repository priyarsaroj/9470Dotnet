<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinqToSql_CRUD.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>LINQ to SQL CRUD</title>
<style type="text/css">
.GridviewDiv {font-size: 100%; font-family: 'Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helevetica, sans-serif; color: #303933;}
.headerstyle
{
color:#FFFFFF;border-right-color:#abb079;border-bottom-color:#abb079;background-color: #df5015;padding:0.5em 0.5em 0.5em 0.5em;text-align:center;
}
</style>
</head>
<body>
<form id="form1" runat="server">
<div class="GridviewDiv">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" DataKeyNames="Id,First_name,Last_name,Address,Phone_No" ShowFooter="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" OnRowCommand ="GridView1_RowCommand">
<HeaderStyle CssClass="headerstyle" />
<Columns>
<asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" />
<asp:TemplateField HeaderText="First_Name">
<ItemTemplate>
<asp:Label ID="lblFirst_Name" runat="server" Text='<%# Eval("First_Name")%>'/>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="txtFirst_Name" runat="server" Text='<%# Eval("First_Name")%>'/>
</EditItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtFirst_Name" runat="server" />
</FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText = "Last_Name">
<ItemTemplate>
<asp:Label ID="lblLast_Name" runat="server" Text='<%# Eval("Last_Name")%>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="txtLast_Name" runat="server" Text='<%# Eval("Last_Name")%>'/>
</EditItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtLast_Name" runat="server" />
</FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText = "Address">
<ItemTemplate>
<asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address")%>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="txtAddress" runat="server" Text='<%# Eval("Address")%>'/>
</EditItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtAddress" runat="server" />
</FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Phone_No">
<ItemTemplate>
<asp:Label ID="lblPhone_No" runat="server" Text='<%# Eval("Phone_No")%>'/>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="txtPhone_No" runat="server" Text='<%# Eval("Phone_No")%>'/>
</EditItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtPhone_No" runat="server" />
<asp:Button ID="btnAdd" CommandName="AddNew" runat="server" Text="Add" />
</FooterTemplate>
</asp:TemplateField>
<asp:CommandField ShowEditButton="True" ShowDeleteButton="true" />
</Columns>
</asp:GridView>
<asp:Label ID="lblresult" runat="server"></asp:Label>
</div>
    </form>
    </body>
    </html>  