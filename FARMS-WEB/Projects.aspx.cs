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
using System.Configuration;
using FARMS_WEB.REST;

namespace FARMS_WEB
{
    public partial class MeusProjetos : System.Web.UI.Page
    {
        private ProjetoRest projetoRest = new ProjetoRest();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.GetProjects();
        }

        private async void GetProjects()
        {
            gvProjetos.DataSource = await this.projetoRest.GetProjects();
            gvProjetos.DataBind();
        }
    }
}