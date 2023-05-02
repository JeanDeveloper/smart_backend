using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Request
{
    public class StatusRequest
    {
        public int codSolDoc{ get; set; }
        public int codEstado{ get; set; }
        public string obs { get; set; } = null;
        public string creadoPor { get; set; }

    }
}
