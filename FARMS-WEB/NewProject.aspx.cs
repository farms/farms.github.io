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
using FARMS_WEB.REST;

namespace FARMS_WEB
{
    public partial class NovoProjeto : System.Web.UI.Page
    {
        private ProjetoRest projetoRest = new ProjetoRest();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private async void AddProject()
        {
            Projeto projeto = new Projeto { Titulo = this.txtTitulo.Text, Descricao = this.txtDescricao.Text, Objetivo = this.txtObjetivos.Text };
            string resposta = await this.projetoRest.AddProject(projeto);
        }

        protected void btnCriar_Click(object sender, EventArgs e)
        {
            this.AddProject();
        }
    }
}