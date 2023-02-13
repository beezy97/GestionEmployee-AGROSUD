using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.SiteService
{
    public interface ISiteService
    {
        Task<List<Site>> GetAllSite();
        Task<Site?> GetSingleSite(int id);
        Task<List<Site>> AddSite([FromBody] Site site1);
        Task<List<Site>?> UpdateSite(int id, Site request);
        Task<List<Site>?> DeleteSite(int id);
    }
}
