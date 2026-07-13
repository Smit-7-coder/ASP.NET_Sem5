<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET_Project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Dashboard" runat="server">
        <div class="parent">
    <div class="container d-flex justify-content-center align-items-center vh-100">
  <div class="card shadow p-4 login-card">
    <h3 class="text-center mb-4">Registration</h3>

    <form [formGroup]="loginForm">
        <div class="mb-3">
  <label class="form-label">Name</label>
  <input
    type="text"
    class="form-control"
    placeholder="Enter Name"
    formControlName="Name"
  />
</div>
      <div class="mb-3">

        <label class="form-label">Email</label>
        <input
          type="email"
          class="form-control"
          placeholder="Enter Email"
          formControlName="userName"
        />
      </div>

      <div class="mb-3">
        <label class="form-label">Password</label>
        <input
          type="password"
          class="form-control"
          placeholder="Enter Password"
          formControlName="password"
        />
      </div>

        <div class="mb-3">
  <label class="form-label">Confirm Password</label>
  <input
    type="password"
    class="form-control"
    placeholder="Enter Confirm Password"
    formControlName="CPassword"
  />
</div>

      <button type="button" (click)="onRegister()" class="btn btn-primary w-100">
        Register
      </button>
        <p class="text-muted mb-0">
        Already have an account?
        <a href="Home.aspx"
        class="text-decoration-none fw-semibold">
            Login
         </a>
        </p>   

    </form>
  </div>
</div>
</div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
