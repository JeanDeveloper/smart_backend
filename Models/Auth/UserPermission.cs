using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Models.Auth
{
    public class UserPermission
    {
        public int codigo { get; set; }
        public int codMenu { get; set; }
        public string nombreMenu { get; set; }
        public int codSubMenu { get; set; }
        public string nombreSubMenu { get; set; }

    }
}
