using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Response
{
    public class RequestByAuthorityResponse
    {

        public int codigo { get; set; }
        public string codeEncrypt { get; set; }
        public string codCliente { get; set; }
        public int cant_pers { get; set; }
        public string ingreso { get; set; }
        public string sede { get; set; }
        public string subsede { get; set; }
        public string ambito { get; set; }
        public string empresa { get; set; }
        public string ruc { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int estado_fin { get; set; }
        public string estado { get; set; }

    }

    public class RequestByContractorResponse
    {

        public int cabecera { get; set; }
        public int cant_pers { get; set; }
        public string codCliente { get; set; }
        public string codeEncrypt { get; set; }
        public string ingreso { get; set; }
        public string sede { get; set; }
        public string subsede { get; set; }
        public string ambito { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int estado { get; set; }
        public int estadoReal { get; set; }
        public string nombre { get; set; }

    }

    public class CreateRequestResponse
    {

        public int estado { get; set; }
        public int codCabecera { get; set; }

    }
    public class CodeEncryptResponse
    {

        public int estado { get; set; }

    }



}
