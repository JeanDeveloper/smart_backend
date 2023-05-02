using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Response
{
    public class ContractorByCustomerResponse
    {
        [JsonProperty(PropertyName = "codigo")]
        public int codigo { get; set; }
        [JsonProperty(PropertyName = "codigoEmpresa")]
        public int codEmpresa { get; set; }
        public string razonSocial { get; set; }
        public string ruc { get; set; }
        public string codeEncrypt { get; set; }
        public string rubro { get; set; }
        public string representante { get; set; }
        public int? cantUsers { get; set; }
        public bool? estado { get; set; }

    }
}
