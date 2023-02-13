using AgricultureWebApi.Context;
using AgricultureWebApi.Models;
using AgricultureWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace AgricultureWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgriculturalProductController : ControllerBase
    {
        private readonly AgricultureDbContext _context;
        public AgriculturalProductController(AgricultureDbContext context)
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


                return Enumerable.Empty<ViewModelAgriculturalProduct>();
            }
          
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<ViewModelAgriculturalProduct>> GetById(int id)
        {
            try
            {
                List<ViewModelAgriculturalProduct> product = new();

                foreach (var item in _context.AgriculturalProduct.Where(s=>s.AgricalturalTypeId==id).ToList())
                {
                    ViewModelAgriculturalProduct data = new()
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


                return Enumerable.Empty<ViewModelAgriculturalProduct>();
            }
        }

    }
}
