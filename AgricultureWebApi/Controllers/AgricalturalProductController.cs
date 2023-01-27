using AgricultureWebApi.Context;
using AgricultureWebApi.Models;
using AgricultureWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgricultureWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgricalturalProductController : ControllerBase
    {
        private readonly AgricultureDbContext _context;
        public AgricalturalProductController(AgricultureDbContext context)
        {
            this._context = context;
        }   
        
        [HttpGet]
        public async Task<IEnumerable<ViewModelAgriculturalProduct>> Get()
        {
            try
            {
                List<ViewModelAgriculturalProduct> product = new();

                foreach (var item in _context.AgriculturalProduct.ToList())
                {
                    ViewModelAgriculturalProduct data = new()
                    {
                        Id = item.Id,
                        AgricalturalTypeId = item.AgricalturalTypeId,
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
                    Place="Get Metot form AgriculturalProduct Controller",
                    Time=DateTime.UtcNow,
                };
                _context.Errors.Add(error);
                await _context.SaveChangesAsync();
                throw new NotImplementedException(); 
            }
          
        }

    }
}
