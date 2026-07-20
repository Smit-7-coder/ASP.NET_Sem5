<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="ASP.NET_Project.HOME" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Dashboard" runat="server">

<div class="container d-flex justify-content-center align-items-center vh-100">

    <div class="card shadow p-4" style="width:450px;">

        <h3 class="text-center mb-4">Login</h3>

        <div class="mb-3">
            <label>Email</label>

            <asp:TextBox
                ID="txtEmail"
                runat="server"
                CssClass="form-control"
                TextMode="Email"
                placeholder="Enter Email">
            </asp:TextBox>

        </div>

        <div class="mb-3">

            <label>Password</label>

            <asp:TextBox
                ID="txtPassword"
                runat="server"
                CssClass="form-control"
                TextMode="Password"
                placeholder="Enter Password">
            </asp:TextBox>

        </div>

        <asp:Button
            ID="btnLogin"
            runat="server"
            Text="Login"
            CssClass="btn btn-primary w-100"
            OnClick="btnLogin_Click" />

        <hr />

        <h5>Upload File</h5>

        <asp:FileUpload
            ID="fuImage"
            runat="server"
            CssClass="form-control" />

        <br />

        <asp:Button
            ID="btnUpload"
            runat="server"
            Text="Upload File"
            CssClass="btn btn-success w-100"
            OnClick="btnUpload_Click" />

        <br /><br />

        <asp:Label
            ID="lblMessage"
            runat="server"
            CssClass="text-success">
        </asp:Label>

    </div>

</div>

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">
</asp:Content>