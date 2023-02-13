using GestionEmployee.Data;
using GestionEmployee.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Services.SiteService
{
    public class SiteService : ISiteService
    {
        private static List<Site> site = new List<Site> {
        
        };

        private readonly DataContext _context;

        public SiteService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Site>> AddSite([FromBody] Site site1)
        {
            _context.Sites.Add(site1);
            await _context.SaveChangesAsync();
            return site;
        }

        public async Task<List<Site>?> DeleteSite(int id)
        {
            var site1 = await _context.Sites.FindAsync(id);
            if (site1 == null)
                return null;

            _context.Sites.Remove(site1);

            await _context.SaveChangesAsync();


            return site;
        }

        public async Task<List<Site>> GetAllSite()
        {
            var site = await _context.Sites.ToListAsync();
            return site;
        }

        public async Task<Site?> GetSingleSite(int id)
        {
            var site1 = _context.Sites.Find(id);
            if (site1 == null)
                return null;
            return site1;
        }

        public async Task<List<Site>?> UpdateSite(int id, Site request)
        {
            var site1 = _context.Sites.Find(id);
            if (site1 == null)
                return null;

            site1.city = request.city;

            await _context.SaveChangesAsync();

            return site;
        }
    }
}

