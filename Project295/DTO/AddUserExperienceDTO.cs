namespace Project295.API.DTO
{
    public class AddUserExperienceDTO
    {
        public string? UserExperienceTitle { get; set; }
        public string? UserExperienceDiscription { get; set; }
        public DateTime? UserExperienceDateFrom { get; set; }
        public DateTime? UserExperienceDateTo { get; set; }
        public int? UserId { get; set; }
    }
}
