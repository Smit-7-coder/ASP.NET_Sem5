    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HELLO.aspx.cs" Inherits="ASP.NET_Project.HELLO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Emial"  ForeColor="#000099"></asp:Label>
        &nbsp;<asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Emial"  ForeColor="#000099"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPassword" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="" ForeColor="#000099"></asp:Label>
        </p>

        <asp:Button ID="LOGIN" runat="server" Text="Addition" OnClick="LOGIN_Click" />
        <asp:Button ID="sub" runat="server" Text="Substraction" OnClick="sub_Click" />
    </form>
</body>
</html>
