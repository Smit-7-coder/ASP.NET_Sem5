<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="ASP.NET_Project.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Is Required" ForeColor="#FF3300" ControlToValidate="Nametxt"></asp:RequiredFieldValidator>
        </div>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="Passwordtxt" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Passwordtxt" ErrorMessage="Password Is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Conform Password : "></asp:Label>
            <asp:TextBox ID="CPasswordtxt" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Passwordtxt" ControlToValidate="CPasswordtxt" ErrorMessage="Password and Confirm Password Must Be Same" ForeColor="#FF3300"></asp:CompareValidator>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Emailtxt" ErrorMessage="Invalid Email" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Contack no "></asp:Label>
            <asp:TextBox ID="Contactxt" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Contactxt" ErrorMessage="Enter 10 Digits Contact Number" ForeColor="#FF3300" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
    <p>
&nbsp;</p>
</body>
</html>
