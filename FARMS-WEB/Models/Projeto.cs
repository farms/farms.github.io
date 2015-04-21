using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace FARMS_WEB.Models
{
    [DataContract] 
    public class Projeto
    {
        [IgnoreDataMember]
        private long Id { get; set; }

        [DataMember(Name = "descricao")] 
        public String Descricao { get; set; }

        [DataMember(Name = "titulo")] 
        public String Titulo { get; set; }

        [DataMember(Name = "objetivo")] 
        public String Objetivo { get; set; }
    }

}