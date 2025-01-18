namespace Project295.API.DTO
{
    public class UpdatePostDTO
    {
        public int PostId { get; set; }
        public string? Contant { get; set; }
        public int? CategoryId { get; set; }
        public int? PostStatusId { get; set; }
        public int? AttachmentId { get; set; }
        public string? AttachmentPath { get; set; }
        public IFormFile? Attachment { get; set; }
    }
}
