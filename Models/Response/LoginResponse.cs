using smart_backend.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Response
{
    public class LoginResponse
    {
        public int status { get; set; }
        public string token { get; set; }
        public string message { get; set; }
        public User user { get; set; }
    }


    public class LoginDBResponse
    {
        public int estado { get; set; }
        public string mensaje { get; set; }
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nroDoc { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string tipoUsuario { get; set; }
        public string codCliente { get; set; }
        public int codEmpresa { get; set; }
        public int codPersonal { get; set; }
    }
}
