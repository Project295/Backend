namespace Project295.API.DTO
{
    public class GetAllUserSkillsDTO
    {
        public int UserSkillId { get; set; }
        public string? SkillName { get; set; }
        public int? SkillId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
