using JugendSpracheAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JugendSpracheAPI.Controllers.Helpers
{
    public class ReadFileService : IReadFileService
    {
        public readonly IFileIO _fileIO;
        public ReadFileService(IFileIO fileIO)
        {
            _fileIO = fileIO;
        }

        public ObjectResult GetCounter(string path)
        {
            var dataFromFile = _fileIO.Read(path);
            if (dataFromFile != null)
            {
                return new ObjectResult(dataFromFile.Count) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult("No Data available") { StatusCode = 400};
            }
        }
    }
}
