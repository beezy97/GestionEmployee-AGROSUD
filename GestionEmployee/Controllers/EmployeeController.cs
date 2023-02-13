using GestionEmployee.Models;
using GestionEmployee.Services.EmployeeService;
using GestionEmployee.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployee()
        {
            return await _employeeService.GetAllEmployee();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Employee>>> GetSingleEmployee(int id)
        {
            var result = await _employeeService.GetSingleEmployee(id);
            if (result == null)
                return NotFound("Employee not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee([FromBody] Employee employee1)
        {
            var result = await _employeeService.AddEmployee(employee1);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(int id, Employee request)
        {
            var result = await _employeeService.UpdateEmployee(id, request);
            if (result == null)
                return NotFound("Employee not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (result == null)
                return NotFound("Employee not found");
            return Ok(result);
        }
    }
}
