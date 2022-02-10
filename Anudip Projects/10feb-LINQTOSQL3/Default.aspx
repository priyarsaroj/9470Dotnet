<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LINQTOSQL3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>LINQ to SQL Insert, Update, Delete Operations in ASP.Net Gridview</title>
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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" AllowPaging="True" DataKeyNames="Id,Name" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" OnRowCommand ="GridView1_RowCommand"> 
<HeaderStyle CssClass="headerstyle" />
<Columns>
<asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" />
<asp:TemplateField HeaderText="Name">
<ItemTemplate>
<asp:Label ID="lblName" runat="server" Text='<%# Eval("Name")%>'/>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name")%>'/>
</EditItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtfName" runat="server" />
</FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText = "Location">
<ItemTemplate>
<asp:Label ID="lblLocation" runat="server" Text='<%# Eval("Location")%>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="txtLocation" runat="server" Text='<%# Eval("Location")%>'/>
</EditItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtfLocation" runat="server" />
</FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Gender">
<ItemTemplate>
<asp:Label ID="lblGender" runat="server" Text='<%# Eval("Gender")%>'/>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="txtGender" runat="server" Text='<%# Eval("Gender")%>'/>
</EditItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtfGender" runat="server" />
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