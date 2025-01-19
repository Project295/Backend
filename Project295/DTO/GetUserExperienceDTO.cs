namespace Project295.API.DTO
{
    public class GetUserExperienceDTO
    {
        public int UserExperienceId { get; set; }
        public string? UserExperienceTitle { get; set; }
        public string? UserExperienceDiscription { get; set; }
        public DateTime? UserExperienceDateFrom { get; set; }
        public DateTime? UserExperienceDateTo { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
