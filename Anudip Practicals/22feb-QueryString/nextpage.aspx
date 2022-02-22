<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nextpage.aspx.cs" Inherits="QueryString.nextpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnretrievevalue" runat="server" Text="retrievevalue" OnClick="btnretrievevalue_Click" />
                    </td>
               </tr>
                <tr>
                     <td>
                         <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="city"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
