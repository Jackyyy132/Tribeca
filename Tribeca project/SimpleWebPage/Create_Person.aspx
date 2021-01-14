<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create_Person.aspx.cs" Inherits="SimpleWebPage.Create_Person" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="text-align:center">Create a person</h1>

    <div align ="center">
    <asp:Label Text ="Name" runat="server" />
    <asp:TextBox runat="server" Enabled ="true" CssClass="form-control input-sm" placeholder="Person Name" />

    <br />
    <br />


    <asp:Label Text ="Surname" runat="server" />
    <asp:TextBox runat="server" Enabled ="true" CssClass="form-control input-sm" placeholder="Person Surname" />

    <br />
    <br />


    <asp:Label Text ="Date Of Birth" runat="server" />
    <asp:TextBox runat="server" Enabled ="true" TextMode ="Date" CssClass="form-control input-sm" placeholder="Person Date of Birth" />

        <br />
        <br />
    
    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary" Width ="200" runat="server"  />
    </div>

</asp:Content>
