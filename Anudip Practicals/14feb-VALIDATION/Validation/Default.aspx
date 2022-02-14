<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Validation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Your name:<br />
    <asp:TextBox runat="server" id="txtName" />
    <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="txtName" errormessage="Please enter your name!" />
    <br /><br /><asp:Button runat="server" id="btnSubmitForm" text="Ok" onclick="btnSubmitForm_Click" />
    </form>
</body>
</html>
