using Microsoft.IdentityModel.Tokens;

namespace Project295.API.DTO
{
    public class UpdateUserDTO
    {
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public IFormFile? image { get; set; }
        
  
    }
}
