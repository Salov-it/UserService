using System;
using System.Data;

namespace UserService.Domain
{
    public class SocialMediaType
    {
        public Guid id {  get; set; }
        public string value { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}
