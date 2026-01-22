using Learnership.Services.DTOs;
using Learnership.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Learnership.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _service;

        public SkillsController(ISkillService service)
        {
            _service = service;
        }

        [HttpGet("last-year")]
        public async Task<IActionResult> GetLastYear()
        {
            return Ok(await _service.GetSkillsCreatedLastYearAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SkillCreateDto dto)
        {
            await _service.CreateSkillAsync(dto);
            return Ok();
        }
    }
}
