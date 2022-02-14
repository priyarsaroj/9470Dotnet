<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Validation_Controls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:66%;">
       <tr>
         <td class="style1" colspan="3" align="center">
         <asp:Label ID="lblmsg" Text="ASP.NET Validation Controls" runat="server" style="width:600px" Font-Size="XX-Large" Font-Bold="True" align="left"/>
         </td>
      </tr>
        <tr>
            <td>First Name :</td>
            <td><asp:TextBox ID="txtFirstName" runat="server" CausesValidation="True" style="width:239px">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter first name" ControlToValidate="txtFirstName"> Required
                </asp:RequiredFieldValidator>
           </td>
        </tr>
        
        <tr>
            <td>Last Name:</td>
            <td><asp:TextBox ID="txtLastName" runat="server" style="width:239px">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter last name" ControlToValidate="txtLastName"> Required
                </asp:RequiredFieldValidator>
           </td>
        </tr>
        
       <tr>
         <td>Education:</td>
         <td><asp:DropDownList ID="ddlEducation" runat="server"  style="width:239px">
             <asp:ListItem>Please select qualification</asp:ListItem>
             <asp:ListItem>Ph.D</asp:ListItem>
             <asp:ListItem>Post-Graduate</asp:ListItem>
             <asp:ListItem>Under-Graduate</asp:ListItem>
             <asp:ListItem>Higher-Secondary</asp:ListItem>
             </asp:DropDownList>
         </td>
       </tr>
        
        <tr>
         <td>Password :</td>
         <td><asp:TextBox ID="txtPassword" runat="server" style="width:239px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter password" ControlToValidate="txtPassword"> Required
             </asp:RequiredFieldValidator>
        </td>
       </tr>
        
        <tr>
         <td>Confirm Password:</td>
         <td><asp:TextBox ID="txtConfirmtxtPassword" runat="server" style="width:239px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Please confirm the password" ControlToValidate="txtConfirmtxtPassword" ControlToCompare="txtPassword">*
            </asp:CompareValidator>
        </td>
       </tr>

       <tr>
        <td>Age:</td>
        <td><asp:TextBox ID="txtAge" runat="server" style="width:239px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age limit between 20 and 30 " ControlToValidate="txtAge" MaximumValue="30" MinimumValue="20" Type="Integer">
            </asp:RangeValidator>
       </td>
      </tr>
        
      <tr>
       <td>Email ID:</td>
       <td><asp:TextBox ID="txtEmail" runat="server" style="width:239px"></asp:TextBox>
           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server" ErrorMessage="Please enter valid email id" ControlToValidate="txtEmail">
           </asp:RegularExpressionValidator>
       </td>
     </tr>
        
     <tr>
       <td>Mobile Number:</td>
       <td><asp:TextBox ID="txtMobileNumber" runat="server" style="width:239px"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationExpression="^(\d\d\d\d\d\d\d\d\d\d)?$"  runat="server" ErrorMessage="Please enter number" ControlToValidate="txtMobileNumber"> Required
           </asp:RequiredFieldValidator>
      </td>
    </tr>

    <tr>
      <td>Message:</td>
      <td><asp:TextBox ID="txtMessage" runat="server" style="width:239px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Text must be exactly 10 characters long!" ControlToValidate="txtMessage"> Required
          </asp:RequiredFieldValidator>*Text must be 10 characters long!
     </td>
    </tr>
     <tr>
     <td>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click"></asp:Button>
    </td>
    </tr>
       </table>
    </form>
</body>
</html>