using GestionEmployee.Models;
using GestionEmployee.Services.ServiceService;
using GestionEmployee.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Service>>> GetAllService()
        {
            return await _serviceService.GetAllService();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Service>>> GetSingleService(int id)
        {
            var result = await _serviceService.GetSingleService(id);
            if (result == null)
                return NotFound("Service not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Service>>> AddService([FromBody] Service service1)
        {
            var result = await _serviceService.AddService(service1);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Service>>> UpdateService(int id, Service request)
        {
            var result = await _serviceService.UpdateService(id, request);
            if (result == null)
                return NotFound("Service not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Service>>> DeleteService(int id)
        {
            var result = await _serviceService.DeleteService(id);
            if (result == null)
                return NotFound("Service not found");
            return Ok(result);
        }
    };
}

