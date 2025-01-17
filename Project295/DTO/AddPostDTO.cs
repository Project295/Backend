namespace Project295.API.DTO
{
    public class AddPostDTO
    {
        public string? Contant { get; set; }
        public int? CategoryId { get; set; }
        public int? PostStatusId { get; set; }
        public int? UserId { get; set; }
        public IFormFile? Attachment{  get; set; }
    }
}
