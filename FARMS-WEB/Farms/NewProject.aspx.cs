using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using FARMS_WEB.Models;
using Newtonsoft.Json;
using System.Text;

namespace FARMS_WEB
{
    public partial class NovoProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private async void CriarProjeto()
        {
            using (HttpClient http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://192.168.25.6:8182/");
                Projeto projeto = new Projeto { Titulo = this.txtTitulo.Text, Descricao = this.txtDescricao.Text, Objetivo = this.txtObjetivos.Text};
                string projetoAsString = JsonConvert.SerializeObject(projeto);
                StringContent content = new StringContent(projetoAsString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await http.PostAsync("/project", content);
                if (response.IsSuccessStatusCode)
                {
                    string project = await response.Content.ReadAsStringAsync();
                }
            }
        }

        protected void btnCriar_Click(object sender, EventArgs e)
        {
            this.CriarProjeto();
        }
    }
}