using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smart_backend.Models.Auth;
using smart_backend.Models.Request;
using smart_backend.Models.Response;
using smart_backend.Services;
using smart_backend.Utilities;

namespace smart_backend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]


    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // POST api/auth/login
        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest request)
        {
            var response = await _authService.Authenticate(request);
            //if (response.status == -1 || response.status == 0) return Unauthorized(response);
            return response;
        }

        // POST api/auth/validate-token
        [HttpGet("validate-token")]
        public async Task<ActionResult<ValidateTokenResponse>> ValidateToken()
        {
            var userId = this.GetCurrentUser();
            if (userId.IsNull()) return Unauthorized();
            var response = await _authService.Validate(userId);
            if (response.codigo == 0) return Unauthorized();
            return response;
        }
        [HttpGet("user")]
        public async Task<ActionResult<User>> getUser(int codeUser)
        {
            var response = await _authService.GetUser(codeUser);
            return response;
           
        }
    }
}
