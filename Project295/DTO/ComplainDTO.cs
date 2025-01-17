namespace Project295.API.DTO
{
    public class ComplainDTO
    {
        public int ComplainId { get; set; }
        public string? ComplainDiscription { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? IsActive { get; set; }
        public int? ComplainantId { get; set; }
        public string? ComplainantFirstName { get; set; }
        public string? ComplainantLastName { get; set; }
        public int? PostId { get; set; }
        public string? Contant { get; set; }
        public bool? IsBlocked { get; set; }
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
