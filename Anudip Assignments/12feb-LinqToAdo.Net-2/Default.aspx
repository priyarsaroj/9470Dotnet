<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LinqToAdo.Net_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bind Gridview with LINQ to ADO.NET Operations</title>
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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="GridView">

<HeaderStyle CssClass="headerstyle" />
<Columns>
<asp:BoundField HeaderText="First_name" DataField="First_name" />
<asp:BoundField HeaderText="Last_name" DataField="Last_name" />
<asp:BoundField HeaderText="Address" DataField="Address" />
<asp:BoundField HeaderText="Phone_No" DataField="Phone_No"/>
</Columns>
</asp:GridView>
</div>
</form>
</body>
</html>
