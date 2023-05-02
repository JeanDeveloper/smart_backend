using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Request
{
    public class CredentialByContractorRequest
    {
        public string codCliente { get; set; }
        public int codEmpresa { get; set; }

    }

    public class HabilityCredentialRequest
    {
        public int actionCode { get; set; }
        public int codigo { get; set; }
        public string usuario{ get; set; }
        public string creadoPor { get; set; }
    }
}
