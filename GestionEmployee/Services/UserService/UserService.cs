using GestionEmployee.Data;
using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.UserService
{
    public class UserService : IUserService
    {
        private static List<User> user = new List<User> {
        
        };

        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<User>> AddUser([FromBody] User user1)
        {
            _context.Users.Add(user1);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>?> DeleteUser(int id)
        {
            var user1 = await _context.Users.FindAsync(id);
            if (user1 == null)
                return null;

            _context.Users.Remove(user1);

            await _context.SaveChangesAsync();


            return user;
        }

        public async Task<List<User>> GetAllUser()
        {
            var user = await _context.Users.ToListAsync();
            return user;
        }

        public async Task<User?> GetSingleUser(int id)
        {
            var user1 = _context.Users.Find(id);
            if (user1 == null)
                return null;
            return user1;
        }

        public async Task<List<User>?> UpdateUser(int id, User request)
        {
            var user1 = _context.Users.Find(id);
            if (user1 == null)
                return null;

            user1.login = request.login;
            user1.password = request.password;

            await _context.SaveChangesAsync();

            return user;
        }
    }
}
