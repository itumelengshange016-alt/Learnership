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
    public class ProficiencyLevelService : IProficiencyLevelService
    {
        private readonly AppDbContext _context;

        public ProficiencyLevelService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProficiencyLevelDto>> GetActiveProficiencyLevelsAsync()
        {
            return await _context.ProficiencyLevels
                .Where(x => x.RecordStatusId == 1)
                .Select(x => new ProficiencyLevelDto(x.ProficiencyLevelId, x.Description))
                .ToListAsync();
        }

        public async Task DeleteProficiencyLevelAsync(int id)
        {
            var proficiencyLevel = await _context.ProficiencyLevels.FindAsync(id);
            if (proficiencyLevel != null)
            {
                _context.ProficiencyLevels.Remove(proficiencyLevel);
                await _context.SaveChangesAsync();
            }
        }
    }
}
