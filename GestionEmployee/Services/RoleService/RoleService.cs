using GestionEmployee.Data;
using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.RoleService
{
    public class RoleService : IRoleService
    {
        private static List<Role> role = new List<Role> {
         
        };

        private readonly DataContext _context;

        public RoleService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Role>> AddRole([FromBody] Role role1)
        {
            _context.Roles.Add(role1);
            await _context.SaveChangesAsync();
            return role;
        }

        public async Task<List<Role>?> DeleteRole(int id)
        {
            var role1 = await _context.Roles.FindAsync(id);
            if (role1 == null)
                return null;

            _context.Roles.Remove(role1);

            await _context.SaveChangesAsync();


            return role;
        }

        public async Task<List<Role>> GetAllRole()
        {
            var role = await _context.Roles.ToListAsync();
            return role;
        }

        public async Task<Role?> GetSingleRole(int id)
        {
            var role1 = _context.Roles.Find(id);
            if (role1 == null)
                return null;
            return role1;
        }

        public async Task<List<Role>?> UpdateRole(int id, Role request)
        {
            var role1 = _context.Roles.Find(id);
            if (role1 == null)
                return null;

            role1.name = request.name;

            await _context.SaveChangesAsync();

            return role;
        }
    }
}

