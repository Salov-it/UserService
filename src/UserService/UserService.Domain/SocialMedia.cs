

namespace UserService.Domain
{
    public class SocialMedia
    {
        public Guid id { get; set; }
        public string link { get; set; }
        public Guid typeId { get; set; }
        public int ownerId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
