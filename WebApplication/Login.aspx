<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">  
    <div class="row margin-top-60">
        <div class="col-4">
            <div class="box border padding-14">
                <h2>ENTRA</h2>
                <br />
                <asp:Label ID="Alerta" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <label>Nome</label>
                <asp:TextBox ID="NomeAcesso" runat="server"></asp:TextBox>
                <label>Senha</label>
                <asp:TextBox ID="Senha" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Button ID="Entrar" runat="server" OnClick="Entrar_Click" Text="Entrar" />

            </div>
        </div>
    </div>
</asp:Content>