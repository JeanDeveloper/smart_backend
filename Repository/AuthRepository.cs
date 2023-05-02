using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using smart_backend.Models.Response;
using Dapper;
using smart_backend.Utilities;
using smart_backend.Models.Auth;

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

        public IEnumerable<DocumentPermission> GetDocumentPermission(int codeUser)
        {
            var param = new
            {
                codeUser = codeUser
            };

            var query = "EXEC SOLMAR.dbo.VDAPP_GET_USER_DOCUMENT_PERMISSIONS @codeUser";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<DocumentPermission>(query, param);
            }
        }

        public ValidateTokenResponse GetInformationUser(string userId)
        {
            var param = new
            {
                userCode = userId
            };

            var query = "EXEC SOLMAR.dbo.VDAPP_GET_USER_BY_ID @userCode";

            using (var connection = DbConnection.getConnection())
            {
                return connection.QueryFirstOrDefault<ValidateTokenResponse>(query, param);
            }
        }

        public GetUserResponse GetUser(int code)
        {
            var param = new
            {
                userCode = code
            };

            var query = "EXEC SOLMAR.dbo.VDAPP_GET_USER @userCode";

            using (var connection = DbConnection.getConnection())
            {
                return connection.QueryFirstOrDefault<GetUserResponse>(query, param);
            }
        }

        public IEnumerable<UserPermission> GetUserPermission(int codeUser)
        {
            var param = new
            {
                codeUser = codeUser
            };

            var query = "EXEC SOLMAR.dbo.VDAPP_GET_USER_PERMISSIONS @codeUser";

            using (var connection = DbConnection.getConnection())
            {
                return connection.Query<UserPermission>(query, param);
            }

        }
    }
}
