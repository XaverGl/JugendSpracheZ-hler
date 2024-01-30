using Microsoft.AspNetCore.Mvc;

namespace JugendSpracheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        [HttpPost("uploadDataInFile")]
        public IActionResult UploadDataInFile(int number, DateTime DateAndTimeOfEntry) 
        {
            throw new NotImplementedException();
        }
    }
}