using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smart_backend.Models.Request;
using smart_backend.Models.Response;
using smart_backend.Repository;

namespace smart_backend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusRepository _statusRepository;

        public StatusController(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        // POST api/<controller>
        [HttpPost]
        public Task<StatusResponse> RegisterStatus([FromBody] StatusRequest request )
        {
           return Task.FromResult(_statusRepository.registerStatus(request));
        }

    }
}
