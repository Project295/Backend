namespace Project295.API.DTO
{
    public class UpdateUserExperienceDTO
    {
        public int UserExperienceId { get; set; }
        public string? UserExperienceTitle { get; set; }
        public string? UserExperienceDiscription { get; set; }
        public DateTime? UserExperienceDateFrom { get; set; }
        public DateTime? UserExperienceDateTo { get; set; }
    }
}
