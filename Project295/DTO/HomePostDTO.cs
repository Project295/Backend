using Project295.API.Models;

namespace Project295.API.DTO
{
    public class HomePostDTO
    {
        public int? PostId { get; set; }
        public int? PostStatusId { get; set; }
        public int? CategoryId { get; set; }
        public string? Contant { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? PostAttachmentPath { get; set; }
        public string? UserAttachmentPath { get; set; }
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }

    }
}
