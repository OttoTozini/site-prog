using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class ExibirUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LerUsuarios();
        }

        protected void LerUsuarios()
        {
            //2. Construir a string de conexão com o banco de dados.
            string myAcess = Server.MapPath("~/App_Data/DatabaseADS2024.accdb");

            string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + myAcess + ";Persist Security Info=False;";


            //3. Construir o comando SQL para inserir o registro na tabela usuarios.
            string sql = "SELECT UsuarioID,Nome,Email,NomeAcesso FROM Usuarios ORDER BY Nome ASC";

            //4. Enviar os dados para o banco de dados.

            Datapost.DB.DAO db = new Datapost.DB.DAO();

            db.ConnectionString = conexao;

            db.DataProviderName = Datapost.DB.DAO.ProviderName.OleDb;

            Usuarios.DataSource = db.Query(sql);
            Usuarios.DataBind();
        }

        protected void Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chave = Usuarios.SelectedRow.Cells[1].Text;

            Response.Redirect("CadastroUsuario.aspx?key="+chave);
        }
    }
}