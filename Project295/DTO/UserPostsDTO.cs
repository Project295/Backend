namespace Project295.API.DTO
{
    public class UserPostsDTO
    {
        public int PostId { get; set; }
        public string? Contant { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CategoryId { get; set; }
        public int? PostStatusId { get; set; }
        public string? AttachmentPath { get; set; }
        public int? AttachmentId { get; set; }



    }
}
