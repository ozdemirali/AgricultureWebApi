using AgricultureWebApi.Context;
using AgricultureWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgricultureWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TypeController : ControllerBase
    {
        private readonly AgricultureDbContext _context;
        public TypeController(AgricultureDbContext context)
        {
            _context = context; 
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_context.AgricalturalTypes.ToList());
        //}


        // Asecron Works
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgricalturalType>>> GetTypeList()
        {
            return await _context.AgricalturalTypes.ToListAsync();

        }
    }
}
