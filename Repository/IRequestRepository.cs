using smart_backend.Models.Request;
using smart_backend.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smart_backend.Repository
{
    public interface IRequestRepository
    {
        IEnumerable<RequestByAuthorityResponse> getRequestByAuthority(RequestByAuthorityRequest request );
        IEnumerable<DetailRequestGeneralResponse> getDetailRequestGeneral(DetailRequestGeneralRequest request);
        IEnumerable<DetailRequestPersonResponse> getDetailRequestPerson(DetailRequestGeneralRequest request);
        IEnumerable<DetailRequestPersonDocumentResponse> getListPersonsDocumentRequest(DetailRequestPersonDocumentRequest request);
        IEnumerable<PersonObservationDocumentResponse> getListObservationPersonDocument(int code);
        IEnumerable<InductionCourseStatusResponse> getCourseState(InductionCourseStatusRequest request);
        IEnumerable<PersonCommentDocumentResponse> getListCommentPersonDocument(int code);
        IEnumerable<PersonsRequestResponse> GetPersonListRequest(int code);
        IEnumerable<RequestByContractorResponse> GetRequestByContractor(RequestByContractorRequest request);
        IEnumerable<EntryTypeResponse> getListEntryType(string descripcion, string codcliente);
        IEnumerable<SucursalResponse> getListSucursal( string codcliente, string ambito);
        IEnumerable<SedeResponse> getListSede(int codSede);
        IEnumerable<RepresentativeResponse> getListRepresentative(int codSede);
        CreateRequestResponse createRequest(CreateRequestRequest request);
        CodeEncryptResponse updateCodeEncrypt(CodeEncryptRequest request);

    }
}
