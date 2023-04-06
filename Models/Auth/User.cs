using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Auth
{
    public class User
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nroDoc { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string tipoUsuario {get;set;}
        public string codCliente { get; set; }
        public int codEmpresa { get; set; }
        public int codPersonal { get; set; }
    }
}
