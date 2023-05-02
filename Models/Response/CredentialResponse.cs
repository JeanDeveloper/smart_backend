using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Response
{
    public class CredentialByContractorResponse
    {
        public int codigo { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public bool habilitado { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_creacion { get; set; }
    }


    public class HabilityCredentialResponse
    {
        public int estado { get; set; }
    }
}
