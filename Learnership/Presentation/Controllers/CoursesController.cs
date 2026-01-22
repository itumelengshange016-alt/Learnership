using Learnership.Services.DTOs;
using Learnership.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Learnership.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _service;

        public CoursesController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet("advanced-approved")]
        public async Task<IActionResult> GetAdvancedApproved()
        {
            return Ok(await _service.GetAdvancedApprovedCoursesAsync());
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBasics(int id, CourseUpdateDto dto)
        {
            await _service.UpdateCourseBasicsAsync(id, dto);
            return NoContent();
        }
    }
}
