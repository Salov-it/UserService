

namespace UserService.Domain
{
    public class User
    {
        public Guid id { get; set; }
        public int refferalId { get; set; }
        public int ownerId { get; set; }
        public string nick { get; set; }
        public string link { get; set; }
        public DateTime createdAt { get; set; } 
        public DateTime updatedAt { get; set; }
    }
}
