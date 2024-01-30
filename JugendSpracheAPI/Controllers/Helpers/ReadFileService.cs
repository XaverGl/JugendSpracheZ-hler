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

        public ObjectResult GetCounter()
        {
            var dataFromFile = _fileIO.Read();
            if (dataFromFile.Count != 1 && dataFromFile.ContainsKey(DateTime.MinValue))
            {
                return new ObjectResult(dataFromFile.Count) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult("No Data available") { StatusCode = 400 };
            }
        }
    }
}