<%@ Page Title="Meus Projetos" Language="C#" MasterPageFile="~/FARMS.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="FARMS_WEB.MeusProjetos" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:GridView ID="gvProjetos" runat="server" AutoGenerateColumns="true" Width="100%">
        <Columns>
            
        </Columns>
    </asp:GridView>

</asp:Content>
