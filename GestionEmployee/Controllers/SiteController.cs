using GestionEmployee.Models;
using GestionEmployee.Services.SiteService;
using GestionEmployee.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : ControllerBase
    {
        private readonly ISiteService _siteService;
        public SiteController(ISiteService siteService)
        {
            _siteService = siteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Site>>> GetAllSite()
        {
            return await _siteService.GetAllSite();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Site>>> GetSingleSite(int id)
        {
            var result = await _siteService.GetSingleSite(id);
            if (result == null)
                return NotFound("Site not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddSite([FromBody] Site site1)
        {
            var result = await _siteService.AddSite(site1);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Site>>> UpdateSite(int id, Site request)
        {
            var result = await _siteService.UpdateSite(id, request);
            if (result == null)
                return NotFound("Site not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Site>>> DeleteSite(int id)
        {
            var result = await _siteService.DeleteSite(id);
            if (result == null)
                return NotFound("Site not found");
            return Ok(result);
        }
    };
}

