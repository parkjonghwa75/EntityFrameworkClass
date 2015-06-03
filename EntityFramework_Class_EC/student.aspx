﻿<%@ Page Title="Student Details" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="EntityFramework_Class_EC.student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Details</h1>
    <fieldset>
        <label for="txtLastName">Last Name: </label>
        <asp:TextBox ID="txtLastName" runat="server" required MaxLength="50"></asp:TextBox>
    </fieldset>

    <fieldset>
        <label for="txtFirstName">First Name: </label>
        <asp:TextBox ID="txtFirstName" runat="server" required MaxLength="50"></asp:TextBox>
    </fieldset>

    <fieldset>
        <label for="txtEnrollement">Enrollement Date: </label>
        <asp:TextBox ID="txtEnrollement" runat="server" TextMode="Date" ></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" ControlToValidate="txtEnrollement" Type="Date" MinimumValue="01-01-1999" MaximumValue="01-01-2999"></asp:RangeValidator>
    </fieldset>

    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
    </div>

</asp:Content>