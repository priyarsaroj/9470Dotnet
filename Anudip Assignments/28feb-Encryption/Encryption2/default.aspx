<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Encryption2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<u>Encrypt</u><br />
<br />
Original Text:
<asp:TextBox ID="txtOriginalText" runat="server" Text="" />
<br />
<br />
Encrypted Text:
<asp:Label ID="lblEncryptedText" runat="server" Text="" />
<br />
<br />
<asp:Button ID="btnEncrypt" OnClick="Encrypt" Text="Encrypt" runat="server" />
<hr />
<u>Decrypt</u>
<br />
<br />
Encrypted Text:
<asp:TextBox ID="txtEncryptedText" runat="server" Text="" />
<br />
<br />
Decrypted Text:
<asp:Label ID="lblDecryptedText" runat="server" Text="" />
<br />
<br />
<asp:Button ID="btnDecrypt" OnClick="Decrypt" Text="Decrypt" runat="server" />
    </form>
</body>
</html>

