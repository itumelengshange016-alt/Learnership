using Learnership.Domain.Entities;
using Learnership.Infrastructure.Data;
using Learnership.Services.DTOs;
using Learnership.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learnership.Services
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetAdvancedApprovedCoursesAsync()
        {
            return await _context.Courses
                .Where(c => c.IsApproved && !c.IsAssessment)
                .AsEnumerable() 
                .Where(c => int.TryParse(c.NQFLevel, out int lvl) && lvl > 4)
                .ToListAsync();
        }

        public async Task UpdateCourseBasicsAsync(int id, CourseUpdateDto dto)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                course.CourseName = dto.CourseName;
                course.CourseDescription = dto.CourseDescription;
                course.CoursePrice = dto.CoursePrice;
                await _context.SaveChangesAsync();
            }
        }
    }
}
