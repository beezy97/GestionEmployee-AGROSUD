using GestionEmployee.Data;
using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.ServiceService
{
    public class ServiceService : IServiceService
    {
        private static List<Service> service = new List<Service> {
        
        };

        private readonly DataContext _context;

        public ServiceService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Service>> AddService([FromBody] Service service1)
        {
            _context.Services.Add(service1);
            await _context.SaveChangesAsync();  
            return service;
        }

        public async Task<List<Service>?> DeleteService(int id)
        {
            var service1 = await _context.Services.FindAsync(id);
            if (service1 == null)
                return null;

            _context.Services.Remove(service1);

            await _context.SaveChangesAsync();

            return service;
        }

        public async Task<List<Service>> GetAllService()
        {
            var service = await _context.Services.ToListAsync();
            return service;
        }

        public async Task<Service?> GetSingleService(int id)
        {
            var service1 = _context.Services.Find(id);
            if (service1 == null)
                return null;
            return service1;
        }

        public async Task<List<Service>?> UpdateService(int id, Service request)
        {
            var service1 = _context.Services.Find(id);
            if (service1 == null)
                return null;

            service1.name = request.name;

            await _context.SaveChangesAsync();

            return service;
        }
    }
}

