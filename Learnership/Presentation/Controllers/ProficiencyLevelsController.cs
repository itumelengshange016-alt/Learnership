using Learnership.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Learnership.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProficiencyLevelsController : ControllerBase
    {
        private readonly IProficiencyLevelService _service;

        public ProficiencyLevelsController(IProficiencyLevelService service)
        {
            _service = service;
        }

        [HttpGet("active")]
        public async Task<IActionResult> GetActive()
        {
            return Ok(await _service.GetActiveProficiencyLevelsAsync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteProficiencyLevelAsync(id);
            return NoContent();
        }
    }
}
