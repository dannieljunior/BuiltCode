using System.Collections.Generic;
using System.Threading.Tasks;
using application.Contracts;
using application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {

        private readonly ILogger<DoctorController> _logger;
        private readonly IDoctorService _service;

        public DoctorController(ILogger<DoctorController> logger, IDoctorService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Doctor>> Get()
        {
            return await _service.GetDoctorsAsync();
        }
    }
}
