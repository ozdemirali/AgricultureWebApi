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

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        List<ViewModelType> viewModelTypes = new();

        //        foreach (var item in _context.AgricalturalTypes.ToList())
        //        {
        //            ViewModelType data = new()
        //            {
        //                Id = item.Id,
        //                Name = item.Name
        //            };

        //            viewModelTypes.Add(data);
        //        }

        //        return Ok(viewModelTypes);
        //    }
        //    catch (Exception e)
        //    {

        //        return Ok(e.Message);
        //    }


        //}



        //Asecron Works
       [HttpGet]
        public async Task<IEnumerable<ViewModelType>> Get()
        {
            try
            {
                List<ViewModelType> _types = new();

                foreach (var item in _context.AgricalturalTypes.ToList())
                {
                    ViewModelType data = new()
                    {
                        Id = item.Id,
                        Name = item.Name
                    };

                    _types.Add(data);
                }

                return _types;
            }
            catch (Exception e)
            {
                Error error = new()
                {
                    Id = Guid.NewGuid(),
                    Message = e.Message,
                    Place = "Get Metot form AgriculturalProduct Controller",
                    Time = DateTime.UtcNow,
                };
                _context.Errors.Add(error);
                await _context.SaveChangesAsync();

                return Enumerable.Empty<ViewModelType>();

            }
        }
    }
}
