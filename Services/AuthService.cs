using Microsoft.IdentityModel.Tokens;
using smart_backend.Models.Auth;
using smart_backend.Models.Request;
using smart_backend.Models.Response;
using smart_backend.Repository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace smart_backend.Services
{
    public class AuthService: IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<LoginResponse> Authenticate(LoginRequest request)
        {
            var responseDBUser = _authRepository.Authenticate(request.username, request.password);

            var isSucessful = (responseDBUser.codigo == 0) ? false : true;

            var token = isSucessful ? GenerateToken(responseDBUser.codigo.ToString() ) : "";


            var response = new LoginResponse
            {
                status = responseDBUser.estado,
                token = token,
                message = responseDBUser.mensaje,
                user = new User
                {
                    nombres     = responseDBUser.nombres,
                    apellidos   = responseDBUser.apellidos,
                    nroDoc      = responseDBUser.nroDoc,
                    email       = responseDBUser.email,
                    telefono    = responseDBUser.telefono,
                    tipoUsuario = responseDBUser.tipoUsuario,
                    codCliente  = responseDBUser.codCliente,
                    codEmpresa  = responseDBUser.codEmpresa,
                    codPersonal = responseDBUser.codPersonal
                }
            };

            return await Task.FromResult(response);

        }


        private static string GenerateToken(string userId)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var claims = new[] { new Claim(ClaimTypes.Name, userId) };
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(Startup.Configuration.GetSection("SecurityKey").Value));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                "SmartAppClient",
                "SmartAppUser",
                claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: credentials);
            return jwtTokenHandler.WriteToken(token);
        }


    }
}
