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
        public async Task<ViewModelAgriculturalDisease> Post(ViewModelAgriculturalDisease agriculturalDisease)
        {
            try
            {   
                AgriculturalDisease disease= new AgriculturalDisease();
                disease.Id = Guid.NewGuid();
                disease.AgriculturalProductId = agriculturalDisease.AgriculturalProductId;
                disease.DiseaseId = agriculturalDisease.DiseaseId;
                disease.Not = agriculturalDisease.Not;
                disease.ImageName = agriculturalDisease.ImageName;
                _context.AgriculturalDiseases.Add(disease);
                await _context.SaveChangesAsync();
                ViewModelAgriculturalDisease data = new()
                {
                    Id = disease.Id,
                    AgriculturalProductId = agriculturalDisease.AgriculturalProductId,
                    DiseaseId = agriculturalDisease.DiseaseId,
                    Not= agriculturalDisease.Not,
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

                ViewModelAgriculturalDisease _data = new()
                {
                    AgriculturalProductId = agriculturalDisease.AgriculturalProductId,
                    DiseaseId = agriculturalDisease.DiseaseId
                };

                return _data;
            }
           
        }
        
    }
}
