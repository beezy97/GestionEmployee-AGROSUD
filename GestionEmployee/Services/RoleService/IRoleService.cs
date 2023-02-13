using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.RoleService
{
    public interface IRoleService
    {
        Task<List<Role>> GetAllRole();
        Task<Role?> GetSingleRole(int id);
        Task<List<Role>> AddRole([FromBody] Role role1);
        Task<List<Role>?> UpdateRole(int id, Role request);
        Task<List<Role>?> DeleteRole(int id);
    }
}
