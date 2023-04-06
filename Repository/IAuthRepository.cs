using smart_backend.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Repository
{
    public interface IAuthRepository
    {

        LoginDBResponse Authenticate(string username, string password);


    }
}
