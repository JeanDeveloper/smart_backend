using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Response
{

    public class GeneralDocumentPerson
    {
        public string nroDoc { get; set; }
        public bool cumplio{ get; set; }
        public string fullname{ get; set; }
        public DateTime fechaEmision{ get; set; }
        public DateTime fechaCaducidad{ get; set; }
    }
}
