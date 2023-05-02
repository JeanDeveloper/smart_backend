using smart_backend.Models.Auth;
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
        ValidateTokenResponse GetInformationUser(string userId);
        IEnumerable<UserPermission> GetUserPermission(int codeUser);
        IEnumerable<DocumentPermission> GetDocumentPermission(int codeUser);
        GetUserResponse GetUser(int code);

    }
}
