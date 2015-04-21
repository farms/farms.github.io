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
    public partial class MeusProjetos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CarregarProjetos();
        }

        private async void CarregarProjetos()
        {
            using (HttpClient http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://192.168.25.6:8182/");
                HttpResponseMessage response = await http.GetAsync("/project");
                if (response.IsSuccessStatusCode)
                {
                    string projetoAsString = await response.Content.ReadAsStringAsync();
                    List<Projeto> projeto = (List<Projeto>)JsonConvert.DeserializeObject(projetoAsString, typeof(List<Projeto>));
                    gvProjetos.DataSource = projeto;
                    gvProjetos.DataBind();
                }
            }
        }
    }
}