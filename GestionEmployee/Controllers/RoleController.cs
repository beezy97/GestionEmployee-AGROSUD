using GestionEmployee.Models;
using GestionEmployee.Services.RoleService;
using GestionEmployee.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Role>>> GetAllRole()
        {
            return await _roleService.GetAllRole();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Role>>> GetSingleRole(int id)
        {
            var result = await _roleService.GetSingleRole(id);
            if (result == null)
                return NotFound("Role not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Role>>> AddRole([FromBody] Role role1)
        {
            var result = await _roleService.AddRole(role1);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Role>>> UpdateRole(int id, Role request)
        {
            var result = await _roleService.UpdateRole(id, request);
            if (result == null)
                return NotFound("Role not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Role>>> DeleteRole(int id)
        {
            var result = await _roleService.DeleteRole(id);
            if (result == null)
                return NotFound("Role not found");
            return Ok(result);
        }
    };
}

