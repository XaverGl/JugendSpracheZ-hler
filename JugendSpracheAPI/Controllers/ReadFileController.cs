using Microsoft.AspNetCore.Mvc;
using JugendSpracheAPI.Interfaces;

namespace JugendSpracheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadFileController : ControllerBase
    {
        private readonly IReadFileService _fileService;

        public ReadFileController(IReadFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet("GetCounter")]
        public IActionResult GetCounter()
        {
            return _fileService.GetCounter();
        }
    }
}
