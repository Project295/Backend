namespace Project295.API.DTO
{
    public class UpdateUserEducationDTO
    {
        public int UserExperienceId { get; set; }
        public string? UniversityName { get; set; }
        public string? CertificationName { get; set; }
        public DateTime? UserExperienceDateFrom { get; set; }
        public DateTime? UserExperienceDateTo { get; set; }
    }
}
