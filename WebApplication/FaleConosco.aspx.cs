using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SalvarExcecoes;

namespace WebApplication
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            //Validar os Dados
            if (Nome.Text.Trim() == "")
            {
                Alerta.Text = "Digite seu Nome";
            }
            else if (Email.Text.Trim() == "")
            {
                Alerta.Text = "Digite seu E-Mail";
            }
            else if (Mensagem.Text.Trim() == "")
            {
                Alerta.Text = "Digite a Mensagem";
            }
            else if (Motivo.SelectedValue == "0")
            {
                Alerta.Text = "Selecione o Motivo";
            }
            else
            {
                try
                {
                    //Construir Email
                    MailMessage email = new MailMessage();
                    email.To.Add("contato@seudominio.com.br");
                    MailAddress from = new MailAddress("contato@seudominio.com.br");
                    email.From = from;
                    email.Subject = "E-Mail enviado pelo form Fale Conosco";
                    email.Body = "Nome: " + Nome.Text + "\n" + "E-Mail: " + Email.Text + "\n" + "Mensagem: " + Mensagem.Text + "\n" + "Motivo: " + Motivo.SelectedValue + "\n";
                    email.IsBodyHtml = false;

                    //Enviar Email
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "seudominio.com.br";
                    smtp.Credentials = new System.Net.NetworkCredential("contato@seudominio.com.br", "suasenha");
                    smtp.Send(email);

                    Alerta.Text = "Seu E-Mail foi enviado com sucesso!";
                    Alerta.ForeColor = System.Drawing.Color.Blue;
                    Formulario.Visible = false;
                }
                catch (Exception ex)
                {
                    RecuperarExcecao exe = new RecuperarExcecao();
                    exe.Salvar(ex);
                    
                    Alerta.Text = "Houve uma falha ao enviar o E-mail";
                    Alerta.ForeColor = System.Drawing.Color.Red;
                    Formulario.Visible = false;
                }









            }
        }
    }
}