using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smart_backend.Models.Response;
using smart_backend.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smart_backend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        
        // GET: api/<controller>
        [HttpGet("general")]
        public Task<IEnumerable<GeneralDocumentPerson>> GetPersonListDocGeneral( int codSolDoc )
        {
            return Task.FromResult(_personRepository.getListPersonDocList(codSolDoc));
        }
    }
}
