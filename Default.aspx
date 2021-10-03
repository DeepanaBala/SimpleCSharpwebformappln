<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCSharpwebformappln._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   UserName <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    Password <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
 
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>

