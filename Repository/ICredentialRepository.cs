using smart_backend.Models.Request;
using smart_backend.Models.Response;
using System.Collections.Generic;

namespace smart_backend.Repository
{
    public interface ICredentialRepository
    {
        IEnumerable<CredentialByContractorResponse> GetCredentialsByContractor(CredentialByContractorRequest request);
        HabilityCredentialResponse EnabledCredential(HabilityCredentialRequest request);

    }
}
