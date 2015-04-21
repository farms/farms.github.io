using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Configuration;

namespace FARMS_WEB.REST
{
    public class FarmsRest
    {
        private static FarmsRest instance;
        private FarmsRest()
        {

        }

        public static FarmsRest Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FarmsRest();
                }
                return instance;
            }
        }

        public Uri BaseUri
        {
            get{
                return new Uri(ConfigurationManager.AppSettings["URL_FARMSWEBSERVICE"]);
            }
        }

        public readonly string ListProjectsUri = "/project";
        public readonly string CreateProjectUri = "/project";
        
    }
}