using AgricultureWebApi.Context;
using AgricultureWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace AgricultureWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UploadController : ControllerBase
    {
        private readonly AgricultureDbContext _context;
        public UploadController(AgricultureDbContext context)
        {
            _context = context;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadAsync()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                //var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok("Ok");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                Error error = new()
                {
                    Id = Guid.NewGuid(),
                    Message = e.Message,
                    Place = "Upload File From Upload Controller",
                    Time = DateTime.UtcNow,
                };
                _context.Errors.Add(error);
                await _context.SaveChangesAsync();

                return StatusCode(500, $"Internal server error: {e}");
            }
        }
    }
}
