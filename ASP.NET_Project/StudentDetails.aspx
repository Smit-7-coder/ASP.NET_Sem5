<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs"
    Inherits="MultiViewDemo.StudentDetails" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Details - MultiView</title>
</head>
<body>
<form id="form1" runat="server">

    <h2>Student Registration Form</h2>

    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">

        <!-- VIEW 1 : PERSONAL INFORMATION -->
        <asp:View ID="View1" runat="server">

            <h3>Student Personal Information</h3>

            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />

            Gender:
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>

            Address:
            <asp:TextBox ID="txtAddress" runat="server"
                TextMode="MultiLine"></asp:TextBox>
            <br /><br />

            Degree:
            <asp:DropDownList ID="ddlDegree" runat="server">
                <asp:ListItem>Select Degree</asp:ListItem>
                <asp:ListItem>B.Tech</asp:ListItem>
                <asp:ListItem>BCA</asp:ListItem>
                <asp:ListItem>B.Sc</asp:ListItem>
                <asp:ListItem>MCA</asp:ListItem>
            </asp:DropDownList>

            <br /><br />

            <asp:Button ID="btnNext1" runat="server"
                Text="Next"
                OnClick="btnNext1_Click" />

        </asp:View>


        <!-- VIEW 2 : CONTACT INFORMATION -->
        <asp:View ID="View2" runat="server">

            <h3>Student Contact Information</h3>

            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />

            Contact No:
            <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnPrevious" runat="server"
                Text="Previous"
                OnClick="btnPrevious_Click" />

            <asp:Button ID="btnNext2" runat="server"
                Text="Next"
                OnClick="btnNext2_Click" />

        </asp:View>


        <!-- VIEW 3 : SUMMARY -->
        <asp:View ID="View3" runat="server">

            <h3>Student Details Summary</h3>

            <b>Name:</b>
            <asp:Label ID="lblName" runat="server"></asp:Label>
            <br /><br />

            <b>Gender:</b>
            <asp:Label ID="lblGender" runat="server"></asp:Label>
            <br /><br />

            <b>Address:</b>
            <asp:Label ID="lblAddress" runat="server"></asp:Label>
            <br /><br />

            <b>Degree:</b>
            <asp:Label ID="lblDegree" runat="server"></asp:Label>
            <br /><br />

            <b>Email:</b>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>
            <br /><br />

            <b>Contact No:</b>
            <asp:Label ID="lblContact" runat="server"></asp:Label>
            <br /><br />

            <asp:Button ID="btnPrevious2" runat="server"
                Text="Previous"
                OnClick="btnPrevious2_Click" />

        </asp:View>

    </asp:MultiView>

</form>
</body>
</html>