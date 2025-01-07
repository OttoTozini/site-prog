using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Método excetuado quando a pagina é chamada
            if (!IsPostBack) // Se não for um retorno "botao"
            {
                if (! string.IsNullOrEmpty(Request.QueryString["key"]))
                {
                    UsuarioID.Text = Request.QueryString["key"];

                    LeiaUsuario();

                }
            }
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            //1. Validar os dados de entrada
            if(LimparSPC(Nome.Text)=="")
            {
                Alerta.Text = "Digite seu nome";
            }
            else if (LimparSPC(Email.Text) == "")
            {
                Alerta.Text = "Digite seu e-mail";
            }
            else if (LimparSPC(NomeAcesso.Text) == "")
            {
                Alerta.Text = "Digite seu nome para acessar o sistema";
            }
            else if (!CheckName(LimparSPC(NomeAcesso.Text)) == true)
            {
                Alerta.Text = "Nome de Usuário já existente!";
            }
            else if (LimparSPC(Senha1.Text) == "")
            {
                Alerta.Text = "Digite a senha";
            }
            else if (LimparSPC(Senha1.Text) != LimparSPC(Senha2.Text))
            {
                Alerta.Text = "As senhas digitadas são diferentes";
            }
            else
            {
                //2. Construir a string de conexão com o banco de dados.
                string myAcess = Server.MapPath("~/App_Data/DatabaseADS2024.accdb");

                string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+myAcess+";Persist Security Info=False;";

                Datapost.DB.UTIL ut = new Datapost.DB.UTIL();


                //3. Construir o comando SQL para inserir o registro na tabela usuarios.
                string sql = "";

                if (UsuarioID.Text == "")
                {
                    sql = "INSERT INTO Usuarios(Nome,Email,NomeAcesso,Senha) VALUES ('" + LimparSPC(Nome.Text) + "','" + LimparSPC(Email.Text) + "','" + LimparSPC(NomeAcesso.Text) + "','" + ut.Encrypt(LimparSPC(Senha1.Text)) + "')";
                }
                else
                {
                    sql = "UPDATE Usuarios SET Nome ='" + Nome.Text + "',Email='" + Email.Text + "',NomeAcesso='" + NomeAcesso.Text + "',Senha='" + ut.Encrypt (Senha1.Text) + "' WHERE UsuarioID=" + UsuarioID.Text;
                }

                //4. Enviar os dados para o banco de dados.

                Datapost.DB.DAO db = new Datapost.DB.DAO();

                db.ConnectionString = conexao;

                db.DataProviderName = Datapost.DB.DAO.ProviderName.OleDb;

                db.Query(sql);


                Alerta.Text = "Usuario cadastrado";

                //5. Inseriu com sucesso
                LimparCampos();

                Excluir.Visible = false;
            }
        }

        protected string LimparSPC(string valor)
        {   
            return valor.Trim(); 
        
        }

        protected bool CheckName(string valor)
        {
            //1. String de conexão
            //2. Construir a string de conexão com o banco de dados
            string myAcess = Server.MapPath("~/App_Data/DatabaseADS2024.accdb");

            string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + myAcess + ";Persist Security Info=False;";

            //3. Comando SQL
            string sql = "SELECT * FROM Usuarios WHERE NomeAcesso='"+valor+"'";

            //4. Enviar os dados para o banco de dados.
            Datapost.DB.DAO db = new Datapost.DB.DAO();

            db.ConnectionString = conexao;

            db.DataProviderName = Datapost.DB.DAO.ProviderName.OleDb;

            DataTable tb = new DataTable();

            tb = (DataTable)db.Query(sql);

            if(tb.Rows.Count == 1)
            {
                if (tb.Rows[0]["UsuarioID"].ToString() == UsuarioID.Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //Não pode gravar o nome de acesso
            }
            else
            {
                return true;
            }
        }

        protected void LeiaUsuario()
        {
            //1. Busca os dados do Usuario a partir do ID
            string sql = "SELECT * FROM Usuarios WHERE UsuarioID=" + UsuarioID.Text;

            //2. Construir a string de conexão com o banco de dados.
            string myAcess = Server.MapPath("~/App_Data/DatabaseADS2024.accdb");

            string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + myAcess + ";Persist Security Info=False;";

            //4. Enviar os dados para o banco de dados.

            Datapost.DB.DAO db = new Datapost.DB.DAO();

            db.ConnectionString = conexao;

            db.DataProviderName = Datapost.DB.DAO.ProviderName.OleDb;

            DataTable tb = new DataTable();
            Datapost.DB.UTIL ut = new Datapost.DB.UTIL();

            tb = (DataTable)db.Query(sql); //TB = Linha da tabela

            Nome.Text = tb.Rows[0]["Nome"].ToString();
            Email.Text = tb.Rows[0]["Email"].ToString();
            NomeAcesso.Text = tb.Rows[0]["NomeAcesso"].ToString();
            Senha1.Text = ut.Decrypt (tb.Rows[0]["Senha"].ToString());
            Senha2.Text = ut.Decrypt (tb.Rows[0]["Senha"].ToString());

            Excluir.Visible = true;


        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            //2. Construir a string de conexão com o banco de dados.
            string myAcess = Server.MapPath("~/App_Data/DatabaseADS2024.accdb");

            string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + myAcess + ";Persist Security Info=False;";

            string sql = "DELETE FROM Usuarios WHERE UsuarioID =" + UsuarioID.Text;

            //4. Enviar os dados para o banco de dados.

            Datapost.DB.DAO db = new Datapost.DB.DAO();

            db.ConnectionString = conexao;

            db.DataProviderName = Datapost.DB.DAO.ProviderName.OleDb;

            db.Query(sql);
            LimparCampos();

            Excluir.Visible = false;

        }

        protected void LimparCampos()
        {
            Nome.Text = "";
            UsuarioID.Text = "";
            Email.Text = "";
            NomeAcesso.Text = "";
            Senha1.Text = "";
            Senha2.Text = "";
            Alerta.Text = "";

        }
    }
}