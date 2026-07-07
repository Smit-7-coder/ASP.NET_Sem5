<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Standard_Control_Demo.aspx.cs" Inherits="ASP.NET_Project.Standard_Control_Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px" BorderWidth="1px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" BorderColor="Black" BorderWidth="4px" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="GENDER" Text="MALE" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="GENDER" OnCheckedChanged="RadioButton2_CheckedChanged" Text="FEMALE" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="ASP.NET" ValidationGroup="Subject" AutoPostBack="True" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="PHP" ValidationGroup="Subject" AutoPostBack="True" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="JAVA" ValidationGroup="Subject" AutoPostBack="True" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="See Price" OnClick="See_Price"/>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server">
        <asp:ListItem>Junagadh</asp:ListItem>
        <asp:ListItem>Rajkot</asp:ListItem>
        <asp:ListItem>Surat</asp:ListItem>
        <asp:ListItem>Mumbai</asp:ListItem>
</asp:ListBox>

        <asp:Button ID="Button3" runat="server" Text="See Price" OnClick="List_Click"/>
    </form>
</body>
</html>
