using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using smart_backend.Models.Response;
using Dapper;
using smart_backend.Utilities;

namespace smart_backend.Repository
{
    public class AuthRepository : IAuthRepository
    {
        public LoginDBResponse Authenticate(string username, string password)
        {
            var param = new {
                usuario = username,
                clave = password,
            };

            var query = "EXEC SOLMAR.dbo.VDAPP_LOGIN_SMART @usuario, @clave";

            using (var connection = DbConnection.getConnection())
            {
                return connection.QueryFirstOrDefault<LoginDBResponse>(query, param);
            }

        }
    }
}
