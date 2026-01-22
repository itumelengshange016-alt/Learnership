using System;

namespace Learnership.Domain.Entities
{
    public class Course : BaseEntity
    {
        public int CourseId { get; set; }
        public Guid CourseKey { get; set; } = Guid.NewGuid();
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string NQFLevel { get; set; }
        public bool IsAssessment { get; set; }
        public bool IsApproved { get; set; }
        public decimal CoursePrice { get; set; }
    }
}
