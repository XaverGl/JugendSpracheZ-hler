using Microsoft.AspNetCore.Mvc;

namespace JugendSpracheAPI.Interfaces
{
    public interface IReadFileService
    {
        ObjectResult GetCounter(string path);
    }
}
