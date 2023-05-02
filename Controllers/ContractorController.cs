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
    public class ContractorController : ControllerBase
    {
        private readonly IContractorRepository _contractorRepository;

        public ContractorController(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public Task<IEnumerable<ContractorByCustomerResponse>> GetContractorsByCustomer(string customerCode)
        {
            var request = new ContractorByCustomerRequest
            {
                customerCode = customerCode
            };

            return Task.FromResult(_contractorRepository.GetContractorsByCustomer(request));
        }

    }
}
