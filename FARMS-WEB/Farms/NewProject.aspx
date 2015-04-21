<%@ Page Title="Novo Projeto" Language="C#" MasterPageFile="~/FARMS.Master" AutoEventWireup="true" CodeBehind="NewProject.aspx.cs" Inherits="FARMS_WEB.NovoProjeto" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div style="width: 100%">
        <div class="form-group">
            <asp:Label ID="lblTitulo" AssociatedControlID="txtTitulo" runat="server" meta:resourceKey="LblTitulo">Título</asp:Label>
            <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblDescricao" AssociatedControlID="txtDescricao" runat="server" meta:resourceKey="LblDescricao">Descrição</asp:Label>
            <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="6" Width="100%"/>
        </div>
        <div class="form-group">
            <asp:Label ID="lblObjetivos" AssociatedControlID="txtObjetivos" runat="server" meta:resourceKey="LblObjetivos">Objetivos</asp:Label>
            <asp:TextBox ID="txtObjetivos" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="6" Width="100%"/>
        </div>
        <div class="form-group">
            <asp:Label ID="lblTipoProjeto" AssociatedControlID="rblTipoProjeto" runat="server" meta:resourceKey="LblTipoProjeto">Tipo</asp:Label>
            <asp:RadioButtonList ID="rblTipoProjeto" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Text="Revisão Sistemática" Value="0" />
                <asp:ListItem Text="Mapeamento Sistemático" Value="1" />
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            <asp:Button ID="btnCriar" runat="server" Text="Criar" CssClass="btn btn-info" meta:resourceKey="BtnCriar"
                OnClick="btnCriar_Click" />
        </div>
    </div>

</asp:Content>
