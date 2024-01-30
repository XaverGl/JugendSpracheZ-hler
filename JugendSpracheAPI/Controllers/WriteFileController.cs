using JugendSpracheAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JugendSpracheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriteFileController : ControllerBase
    {
        private readonly IWriteFileService _fileService;

        public WriteFileController(IWriteFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost("writeFile")]
        public IActionResult WriteFile(string value)
        {
            return _fileService.WriteFile(value);
        }
    }
}