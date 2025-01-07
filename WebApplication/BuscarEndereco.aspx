<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarEndereco.aspx.cs" Inherits="WebApplication.BuscarEndereco"  Async="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="margin-top-60">
        <h2>Pesquisa de Endereço</h2>
        <br />
        <asp:Label ID="Alerta" ForeColor="Red" Font-Size="16px" runat="server"></asp:Label>

        <label>CEP</label>
        <asp:TextBox ID="CEPText" MaxLength="255" Width="42%" runat="server"></asp:TextBox><asp:Button OnClick="Pesquisa_Click" ID="Pesquisa" runat="server" Text="Pesquisar" />
        
        <label>Rua</label>
        <br />
        <asp:TextBox ID="RuaText" MaxLength="255" Width="50%" runat="server"></asp:TextBox>
        
        <label>Número</label>
        <br />
        <asp:TextBox ID="NumeroText" MaxLength="255" Width="50%" runat="server"></asp:TextBox>
      
        <label>Bairro</label>
        <br />
        <asp:TextBox ID="BairroText" MaxLength="255" Width="50%" runat="server"></asp:TextBox>
      
        <label>Cidade</label>
        <br />
        <asp:TextBox ID="CidadeText" MaxLength="255" Width="50%" runat="server"></asp:TextBox>

        <label>UF</label>
        <br />
        <asp:TextBox ID="UFText" MaxLength="255" Width="50%" runat="server"></asp:TextBox>

    </div>
</asp:Content>
