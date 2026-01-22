using System;
using System.Collections.Generic;

namespace Learnership.Domain.Entities
{
    public class ProficiencyLevel : BaseEntity
    {
        public int ProficiencyLevelId { get; set; }
        public Guid ProficiencyLevelKey { get; set; } = Guid.NewGuid();
        public string Description { get; set; }
        
        public ICollection<Skill> Skills { get; set; }
    }
}
