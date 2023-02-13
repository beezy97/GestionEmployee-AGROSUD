using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUser();
        Task<User?> GetSingleUser(int id);
        Task<List<User>> AddUser([FromBody] User user1);
        Task<List<User>?> UpdateUser(int id, User request);
        Task<List<User>?> DeleteUser(int id);
    }
}
