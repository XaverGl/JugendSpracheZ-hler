using Microsoft.AspNetCore.Mvc;

namespace JugendSpracheAPI.Interfaces
{
    public interface IWriteFileService
    {
        ObjectResult WriteFile(string value);
    }
}