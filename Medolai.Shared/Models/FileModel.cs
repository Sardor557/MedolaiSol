using Microsoft.AspNetCore.Http;

namespace Medolai.Shared.Models
{
    public sealed class FileModel
    {
        public IFormFile File { get; set; }
    }
}
