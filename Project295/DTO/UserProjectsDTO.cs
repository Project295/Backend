namespace Project295.API.DTO
{
    public class UserProjectsDTO
    {
        public int UserProjectId { get; set; }
        public string? UserProjectsTitle { get; set; }
        public string? UserProjectDiscription { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
}
