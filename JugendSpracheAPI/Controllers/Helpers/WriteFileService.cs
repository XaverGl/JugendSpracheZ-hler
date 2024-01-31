using JugendSpracheAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JugendSpracheAPI.Controllers.Helpers
{
    public class WriteFileService : IWriteFileService
    {
        public readonly IFileIO _fileIO;
        public WriteFileService(IFileIO fileIO)
        {
            _fileIO = fileIO;
        }

        public ObjectResult WriteFile(string word, string path)
        {
            var returnValue = _fileIO.Write(word, path, true);

            if (returnValue == string.Empty)
            {
                return new ObjectResult(returnValue) { StatusCode = 200 };
            }
            else
            {
                return new ObjectResult(returnValue) { StatusCode = 400 };
            }
        }
    }
}
