using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Request
{
    public class DetailRequestGeneralRequest
    {
        public int codCabecera { get; set; }
        public string userName{ get; set; }
    }


    public class DetailRequestPersonDocumentRequest
    {
        public int codDetPersona { get; set; }
        public string userName { get; set; }
    }


    public class PersonObservationDocumentRequest
    {
        public int codDetPersona { get; set; }
        public string userName { get; set; }
    }


    public class InductionCourseStatusRequest
    {
        internal string descripcion;

        public string ruc { get; set; }
        public string nroDoc{ get; set; }
        public string enterprise { get; set; }
        public string codeEncrypt{ get; set; }

    }


}
