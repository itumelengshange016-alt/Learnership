using System;

namespace Learnership.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public int SkillId { get; set; }
        public Guid SkillKey { get; set; } = Guid.NewGuid();
        public string SkillName { get; set; }
        public int ProficiencyLevelId { get; set; }
        public bool IsApproved { get; set; }
        public string CorrectedSkillName { get; set; }

        public ProficiencyLevel ProficiencyLevel { get; set; }
    }
}
