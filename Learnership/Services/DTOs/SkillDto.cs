namespace Learnership.Services.DTOs
{
    public record SkillCreateDto(string SkillName, int ProficiencyLevelId);
    public record SkillDto(int Id, string SkillName, int ProficiencyLevelId, string CorrectedSkillName);
}
