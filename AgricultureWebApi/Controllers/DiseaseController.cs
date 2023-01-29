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
                        AgricalturalTypeId = item.AgricalturalTypeId,

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

        
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
