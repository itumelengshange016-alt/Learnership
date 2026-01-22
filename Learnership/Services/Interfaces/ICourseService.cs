using Learnership.Domain.Entities;
using Learnership.Services.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Learnership.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetAdvancedApprovedCoursesAsync();
        Task UpdateCourseBasicsAsync(int id, CourseUpdateDto dto);
    }
}
