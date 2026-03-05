using Medolai.Repository.Services;
using Medolai.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Medolai.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class GtdController : ControllerBase
    {
        private readonly IGdtService gdtService;

        public GtdController(IGdtService gdtService)
        {
            this.gdtService = gdtService;
        }

        [HttpPost("File")]
        public async Task<IActionResult> SaveFile([FromForm] FileModel file)
        {
            var res = await gdtService.SaveFileAsync(file);
            if (res.Code == 1)
                return Ok(res);
            return BadRequest(res);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllForGrid()
        {
            var res = await gdtService.GetAllForGridAsync();
            return Ok(res);
        }
    }
}
