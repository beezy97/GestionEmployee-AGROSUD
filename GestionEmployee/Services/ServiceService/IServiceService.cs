using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.ServiceService
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllService();
        Task<Service?> GetSingleService(int id);
        Task<List<Service>> AddService([FromBody] Service service1);
        Task<List<Service>?> UpdateService(int id, Service request);
        Task<List<Service>?> DeleteService(int id);
    }
}
