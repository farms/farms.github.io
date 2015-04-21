using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using FARMS_WEB.Models;
using Newtonsoft.Json;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace FARMS_WEB.REST
{
    public class ProjetoRest
    {

        public async Task<string> AddProject(Projeto projeto)
        {
            using (HttpClient http = new HttpClient())
            {
                http.BaseAddress = FarmsRest.Instance.BaseUri;
                string projectAsString = JsonConvert.SerializeObject(projeto);
                StringContent content = new StringContent(projectAsString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await http.PostAsync(FarmsRest.Instance.CreateProjectUri, content);
                if (response.IsSuccessStatusCode)
                {
                    string project = await response.Content.ReadAsStringAsync();
                    return project;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Projeto>> GetProjects()
        {
            using (HttpClient http = new HttpClient())
            {
                http.BaseAddress = FarmsRest.Instance.BaseUri;
                HttpResponseMessage response = await http.GetAsync(FarmsRest.Instance.ListProjectsUri);
                if (response.IsSuccessStatusCode)
                {
                    string projetoAsString = await response.Content.ReadAsStringAsync();
                    return (List<Projeto>)JsonConvert.DeserializeObject(projetoAsString, typeof(List<Projeto>));
                }
                else
                {
                    return null;
                }
            }
        }
    }
}