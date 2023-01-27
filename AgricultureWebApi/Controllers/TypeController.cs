using AgricultureWebApi.Context;
using AgricultureWebApi.Models;
using AgricultureWebApi.ViewModels;
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

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<ViewModelType> viewModelTypes = new();

                foreach (var item in _context.AgricalturalTypes.ToList())
                {
                    ViewModelType data = new()
                    {
                        Id = item.Id,
                        Name = item.Name
                    };

                    viewModelTypes.Add(data);
                }

                return Ok(viewModelTypes);
            }
            catch (Exception e)
            {

                return Ok(e.Message);
            }

            
        }



        //Asecron Works
       //[HttpGet]
       // public async Task<ActionResult<IEnumerable<AgricalturalType>>> GetTypeList()
       // {
       //     List<ViewType> viewTypes = new();

       //     foreach (var item in _context.AgricalturalTypes.ToList())
       //     {
       //         ViewType data = new()
       //         {
       //             Id = item.AgricalturalTypeId,
       //             Name = item.Name
       //         };

       //         viewTypes.Add(data);
       //     }

       //     return await _context.AgricalturalTypes.ToListAsync();

       // }
    }
}
