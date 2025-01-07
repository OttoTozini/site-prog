<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibirUsuarios.aspx.cs" Inherits="WebApplication.ExibirUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <div class="row">
        <div class="col-8">
            <div class="box padding-14">
                <h2>Usuarios Cadastrados</h2>
                <br />
                <asp:GridView OnSelectedIndexChanged="Usuarios_SelectedIndexChanged" AutoGenerateSelectButton="true" ID="Usuarios" Width="100%"  ForeColor="Black" BorderWidth="7px" BorderColor="#2672bd" CellPadding="8" runat="server"></asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
