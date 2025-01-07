using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class BuscarEndereco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Pesquisa_Click(object sender, EventArgs e)
        {

            try
            {
                string cepParaPesquisar = CEPText.Text.Trim().Replace("-", "");

                HttpClient client = new HttpClient();

                Uri uri = new Uri($"https://viacep.com.br/ws/{cepParaPesquisar}/json/");

                string resposta = client.GetStringAsync(uri).Result;

                JObject json = JObject.Parse(resposta);

                RuaText.Text = json["logradouro"].ToString();
                BairroText.Text = json["bairro"].ToString();
                CidadeText.Text = json["localidade"].ToString();
                UFText.Text = json["uf"].ToString();
            }

            catch (Exception ex)
            {
                Alerta.Text = ex.Message;
            }

        }
    }
}