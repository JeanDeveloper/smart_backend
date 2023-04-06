using smart_backend.Models.Request;
using smart_backend.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Authenticate(LoginRequest request);
    }
}
