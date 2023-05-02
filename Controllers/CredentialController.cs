using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smart_backend.Models.Request;
using smart_backend.Models.Response;
using smart_backend.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smart_backend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CredentialController : ControllerBase
    {
 
        private readonly ICredentialRepository _credentialRepository;


        public CredentialController(ICredentialRepository credentialRepository)
        {
            _credentialRepository = credentialRepository;
        }


        [HttpGet]
        public Task<IEnumerable<CredentialByContractorResponse>> GetCredentialsByContractor(string codCliente , int codEmpresa)
        {
            var request = new CredentialByContractorRequest
            {
                codCliente = codCliente,
                codEmpresa = codEmpresa
            };

            return Task.FromResult(_credentialRepository.GetCredentialsByContractor(request));

        }


        [HttpPost("hability")]
        public Task<HabilityCredentialResponse> EnabledCredentials([FromBody]HabilityCredentialRequest request )
        {

            return Task.FromResult(_credentialRepository.EnabledCredential(request));

        }

    }
}
