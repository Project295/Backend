namespace Project295.API.DTO
{
    public class UpdatePasswordDTO
    {
        public string? NewPassword { get; set; }
        public string? OldPassword { get; set; }
        public int? UserId { get; set; }

    }
}
