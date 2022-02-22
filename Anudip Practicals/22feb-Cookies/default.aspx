<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Cookies._default" %>

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
                        <asp:Button ID="btncreatecookie" runat="server" Text="Create Cookie" OnClick="btncreatecookie_Click" />
                    </td>                      
                    <td>
                       <asp:TextBox ID="txtcreatecookie" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>

                <tr>                    
                    <td>
                        <asp:Button ID="btnretrievecookie" runat="server" Text="Retrieve Cookie" OnClick="btnretrievecookie_Click" />
                    </td>                      
                    <td>
                       <asp:TextBox ID="txtretrievecookie" runat="server" Width="200px"></asp:TextBox>
                       
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                       
                    </td>
                </tr>               
                    
                </table>  
       </div>
    </form>
</body>
</html>
