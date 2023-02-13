using AgricultureWebApi.Context;
using AgricultureWebApi.Models;
using AgricultureWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgricultureWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DiseaseController : ControllerBase
    {
        private readonly AgricultureDbContext _context;
        public DiseaseController(AgricultureDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ViewModelDisease>> Get()
        {
            try
            {
                List<ViewModelDisease> disease = new();

                foreach (var item in _context.Diseases.ToList())
                {
                    ViewModelDisease data = new()
                    {
                        Id = item.Id,
                        Name = item.Name,
                    };

                    disease.Add(data);
                }

                return disease;
            }
            catch (Exception e)
            {

                Error error = new()
                {
                    Id = Guid.NewGuid(),
                    Message = e.Message,
                    Place = "Get Metot from Disease Controller",
                    Time= DateTime.UtcNow,
                };
                _context.Errors.Add(error);

                await _context.SaveChangesAsync();
                return Enumerable.Empty<ViewModelDisease>();
            }
        }


        [HttpGet("{id}")]
        public async Task<IEnumerable<ViewModelDisease>> GetById(int id)
        {
            try
            {
                List<ViewModelDisease> product = new();

                foreach (var item in _context.Diseases.Where(s => s.AgricalturalTypeId==id || s.AgricalturalTypeId == 3).ToList())
                {
                    ViewModelDisease data = new()
                    {
                        Id = item.Id,
                        Name = item.Name,
                    };

                    product.Add(data);
                }

                return product;
            }
            catch (Exception e)
            {
                Error error = new()
                {
                    Id = Guid.NewGuid(),
                    Message = e.Message,
                    Place = "GetById Metot form AgriculturalProduct Controller",
                    Time = DateTime.UtcNow,
                };
                _context.Errors.Add(error);
                await _context.SaveChangesAsync();


                return Enumerable.Empty<ViewModelDisease>();
            }
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
