<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewState.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lbl" runat="server" Text="Enter Name:"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Clear Value" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text=" Display Value" />
        </div>
       </form>
</body>
</html>
