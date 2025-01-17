namespace Project295.API.DTO
{
    public class UsersDTO
    {
        public int LoginId { get; set; }
        public string? UserName { get; set; }
        public int? RoleId { get; set; }
        public string? RoleName { get; set; }
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? IsBlocked { get; set; }
    }
}
