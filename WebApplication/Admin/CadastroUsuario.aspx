<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="WebApplication.CadastroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="margin-top-60">
        <div>
            <h2>Cadastro de Usuarios</h2>
            <br />
            <asp:Label ID="Alerta" ForeColor="Red" Font-Size="16px" runat="server"></asp:Label>
            <br />
            <asp:Label ID="UsuarioID" FontSize="30px" runat="server"></asp:Label>

            <label>Nome</label>
            <asp:TextBox ID="Nome" MaxLength="255" Width="50%" runat="server"></asp:TextBox>

            <label>E-mail</label>
            <asp:TextBox ID="Email" TextMode="Email" Width="50%" runat="server"></asp:TextBox>

            <label>Nome de Acesso</label>
            <asp:TextBox ID="NomeAcesso" MaxLength="255" Width="50%" runat="server"></asp:TextBox>

            <label>Senha</label>
            <asp:TextBox ID="Senha1" Width="50%" MaxLength="255" runat="server"></asp:TextBox>

            <label>Confirmar Senha</label>
            <asp:TextBox ID="Senha2" Width="50%" MaxLength="255" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="EnvioCadastro" OnClick="Enviar_Click" runat="server" Text="Cadastrar" />
            <asp:Button ID="Excluir" Visible="false" CssClass="botao-delete" OnClick="Excluir_Click" runat="server" Text="Excluir" />


        </div>
    </div>
</asp:Content>
