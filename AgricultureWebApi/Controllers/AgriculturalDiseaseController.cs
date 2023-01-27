using AgricultureWebApi.Context;
using AgricultureWebApi.Models;
using AgricultureWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgriculturalDiseaseController : ControllerBase
    {
        private readonly AgricultureDbContext _context;
        public AgriculturalDiseaseController(AgricultureDbContext context)
        {
            this._context = context;
        }


        [HttpPost]
        public async Task<ViewModelAgricalturalDisease> InsertData(AgricalturalDisease agriculturalDisease)
        {
            try
            {
                agriculturalDisease.Id = Guid.NewGuid();
                _context.AgricalturalDiseases.Add(agriculturalDisease);
                await _context.SaveChangesAsync();
                ViewModelAgricalturalDisease data = new()
                {
                    Id = agriculturalDisease.Id,
                    AgriculturalProductId = agriculturalDisease.AgriculturalProductId,
                    DiseaseId = agriculturalDisease.DiseaseId,
                };
                return data;
            }
            catch (Exception e)
            {
                Error error = new()
                {
                    Id = Guid.NewGuid(),
                    Message = e.Message,
                    Place = "Get Metot from Disease Controller",
                    Time = DateTime.UtcNow,
                };
                _context.Errors.Add(error);

                await _context.SaveChangesAsync();

                throw new NotImplementedException();
            }
           
        }
        
    }
}
