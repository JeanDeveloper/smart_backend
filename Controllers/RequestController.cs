using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smart_backend.Models.Request;
using smart_backend.Models.Response;
using smart_backend.Repository;
using smart_backend.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smart_backend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class RequestController : ControllerBase
    {

        private readonly IRequestRepository _requestRepository;

        public RequestController(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public Task<IEnumerable<RequestByAuthorityResponse>> GetRequestByAuhority(string codCliente, int userCode)
        {
            var request = new RequestByAuthorityRequest
            {
                codCliente = codCliente,
                codUsuario = userCode,
            };

            return Task.FromResult(_requestRepository.getRequestByAuthority(request));

        }


        [HttpPost]
        public Task<CreateRequestResponse> RegisterRequest([FromBody] CreateRequestRequest request )
        {
            return Task.FromResult(_requestRepository.createRequest(request));
        }

        [HttpPost("codeEncrypt")]
        public Task<CodeEncryptResponse> updateCodeEncrypt([FromBody] CodeEncryptRequest request)
        {
            return Task.FromResult(_requestRepository.updateCodeEncrypt(request));
        }

        [HttpGet("contractor")]
        public Task<IEnumerable<RequestByContractorResponse>> GetRequestByContractor(int enterPriseCode, string customerCode)
        {
            var request = new RequestByContractorRequest
            {
                enterPriseCode = enterPriseCode,
                customerCode = customerCode,
            };

            return Task.FromResult(_requestRepository.GetRequestByContractor(request));

        }


        [HttpGet("autorithy/person")]
        public Task<IEnumerable<PersonsRequestResponse>> GetPersonListRequest(int codCabecera)
        {
            return Task.FromResult(_requestRepository.GetPersonListRequest(codCabecera));

        }

        [HttpGet("detail/general")]
        public Task<IEnumerable<DetailRequestGeneralResponse>> GetDetailRequestGeneral(int codCabecera, string userName)
        {
            var request = new DetailRequestGeneralRequest
            {
                codCabecera = codCabecera,
                userName = userName,
            };

            return Task.FromResult(_requestRepository.getDetailRequestGeneral(request));

        }

        [HttpGet("detail/person")]
        public Task<IEnumerable<DetailRequestPersonResponse>> GetDetailRequestPerson(int codCabecera, string userName)
        {
            var request = new DetailRequestGeneralRequest
            {
                codCabecera = codCabecera,
                userName = userName,
            };

            return Task.FromResult(_requestRepository.getDetailRequestPerson(request));

        }

        [HttpGet("detail/person/document")]
        public Task<IEnumerable<DetailRequestPersonDocumentResponse>> GetPersonDocument(int codDetPersona, string userName)
        {
            var request = new DetailRequestPersonDocumentRequest
            {
                codDetPersona = codDetPersona,
                userName = userName,
            };

            return Task.FromResult(_requestRepository.getListPersonsDocumentRequest(request));

        }

        [HttpGet("detail/person/document/observation")]
        public Task<IEnumerable<PersonObservationDocumentResponse>> GetObservationPersonDocument(int code)
        {
            return Task.FromResult(_requestRepository.getListObservationPersonDocument(code));
        }

        [HttpGet("detail/person/document/comment")]
        public Task<IEnumerable<PersonCommentDocumentResponse>> GetCommentPersonDocument(int code)
        {
            return Task.FromResult(_requestRepository.getListCommentPersonDocument(code));
        }

        [HttpGet("person/course")]
        public Task<IEnumerable<InductionCourseStatusResponse>> GetInductionCourseStatus(string ruc, string nroDoc, string enterprise, string codeEncrypt)
        {
            var request = new InductionCourseStatusRequest
            {
                ruc = ruc,
                nroDoc =nroDoc,
                enterprise = enterprise,
                codeEncrypt = codeEncrypt
            };

            return Task.FromResult(_requestRepository.getCourseState(request));
        }

        [HttpGet("entrytype")]
        public Task<IEnumerable<EntryTypeResponse>> GetEntryType(string descripcion, string codcliente)
        {
           

            return Task.FromResult(_requestRepository.getListEntryType(descripcion, codcliente));
        }

        [HttpGet("sucursal")]
        public Task<IEnumerable<SucursalResponse>> GetSucursal(string codcliente,string ambito)
        {


            return Task.FromResult(_requestRepository.getListSucursal( codcliente, ambito));
        }

        [HttpGet("campus")]
        public Task<IEnumerable<SedeResponse>> GetSede(int codSede)
        {
            return Task.FromResult(_requestRepository.getListSede(codSede));
        }

        [HttpGet("representative")]
        public Task<IEnumerable<RepresentativeResponse>> GetRepresentative(int codSede)
        {
            return Task.FromResult(_requestRepository.getListRepresentative(codSede));
        }



    }
}
