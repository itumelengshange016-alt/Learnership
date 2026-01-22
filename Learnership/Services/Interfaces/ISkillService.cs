using Learnership.Domain.Entities;
using Learnership.Services.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Learnership.Services.Interfaces
{
    public interface ISkillService
    {
        Task<List<Skill>> GetSkillsCreatedLastYearAsync();
        Task CreateSkillAsync(SkillCreateDto dto);
    }
}
