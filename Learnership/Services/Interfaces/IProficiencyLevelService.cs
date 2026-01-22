using Learnership.Services.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Learnership.Services.Interfaces
{
    public interface IProficiencyLevelService
    {
        Task<List<ProficiencyLevelDto>> GetActiveProficiencyLevelsAsync();
        Task DeleteProficiencyLevelAsync(int id);
    }
}
