using Learnership.Domain.Entities;
using Learnership.Infrastructure.Data;
using Learnership.Services.DTOs;
using Learnership.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learnership.Services
{
    public class SkillService : ISkillService
    {
        private readonly AppDbContext _context;

        public SkillService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Skill>> GetSkillsCreatedLastYearAsync()
        {
            int lastYear = DateTime.Now.Year - 1;
            return await _context.Skills
                .Where(s => s.CreatedDate.Year == lastYear)
                .OrderBy(s => s.CorrectedSkillName)
                .ToListAsync();
        }

        public async Task CreateSkillAsync(SkillCreateDto dto)
        {
            var skill = new Skill
            {
                SkillName = dto.SkillName,
                ProficiencyLevelId = dto.ProficiencyLevelId,
                IsApproved = false,
                CorrectedSkillName = dto.SkillName 
            };
            _context.Skills.Add(skill);
            await _context.SaveChangesAsync();
        }
    }
}
