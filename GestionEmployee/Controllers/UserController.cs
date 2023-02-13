using GestionEmployee.Models;
using GestionEmployee.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace GestionEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUser()
        {
            return await _userService.GetAllUser();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<User>>> GetSingleUser(int id)
        {
            var result = await _userService.GetSingleUser(id);
            if (result == null)
                return NotFound("User not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser([FromBody]User user1)
        {
            var result = await _userService.AddUser(user1);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(int id, User request)
        {
            var result = await _userService.UpdateUser(id, request);
            if (result == null)
            return NotFound("User not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var result = await _userService.DeleteUser(id);
            if (result == null)
                return NotFound("User not found");
            return Ok(result);
        }
    };
}

