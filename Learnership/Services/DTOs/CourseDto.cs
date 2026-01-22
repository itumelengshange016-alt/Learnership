namespace Learnership.Services.DTOs
{
    public record CourseUpdateDto(string CourseName, string CourseDescription, decimal CoursePrice);
    public record CourseDto(int Id, string CourseName, string CourseDescription, string NQFLevel, decimal CoursePrice);
}
