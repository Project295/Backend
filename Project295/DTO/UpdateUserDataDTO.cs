namespace Project295.API.DTO
{
    public class UpdateUserDataDTO
    {
            public int UserId { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Email { get; set; }
            public string? PhoneNumber { get; set; }
            public string? JobTitle { get; set; }
            public string? Company { get; set; }
            public string? Address { get; set; }
            public string? Brief { get; set; }
            public IFormFile? ProfilePic { get; set; }
            public IFormFile? CoverPic { get; set; }
        
    }
}
