using Microsoft.AspNetCore.Mvc;

namespace JugendSpracheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadFileController : ControllerBase
    {
        [HttpGet("download-1Day-Report")]
        public IActionResult DowloadDailyFile(DateTime dateForData)
        {
            throw new NotImplementedException();
        }

        [HttpGet("download-Week-Report")]
        public IActionResult DownloadWeeklyFile(string startOfWeek, string endOfWeek)
        {
            throw new NotImplementedException();
        }
    }
}