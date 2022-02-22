<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="QueryString._default" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>                      
                    <td>
                       <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>                    
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="City"></asp:Label>
                    </td>                      
                    <td>
                       <asp:TextBox ID="txtcity" runat="server" Width="200px"></asp:TextBox>

                      <asp:Button ID="btnsend" runat="server" Text="Send" OnClick="btnsend_Click"></asp:Button>
                   </td>
                </tr>               
           </table>  
       </div>
     </form>
</body>
</html>
