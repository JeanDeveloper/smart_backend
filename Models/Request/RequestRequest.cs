using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Request
{
    public class RequestByAuthorityRequest
    {
        public string codCliente { get; set; }
        public int codUsuario { get; set; }
    }

    public class RequestByContractorRequest
    {
        public int enterPriseCode { get; set; }
        public string customerCode { get; set; }
    }

    public class CreateRequestRequest
    {
        public int codTipoIngreso { get; set; }
        public string codCliente { get; set; }
        public int codEmpresa { get; set; }
        public int codSede { get; set; }
        public int codSubSede{ get; set; }
        public int codAmbito{ get; set; }
        public int codAutorizante{ get; set; }
        public DateTime fechaInicio{ get; set; }
        public DateTime fechaFin { get; set; }
        public string creadoPor{ get; set; }
        public  bool habilitado { get; set; }

    }
    public class CodeEncryptRequest
    {
        public int codCabecera { get; set; }
        public string codeEncrypt { get; set; }
    }



}
