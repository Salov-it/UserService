using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.Users.Querries.Get
{
    public class GetQuerry : IRequest<User[]>
    {
        public Guid? Id {get;set;}
        public int? RefferalId { get; set; }
        public int? OwnerId { get; set; }
        public string Nick { get; set; }
        public string Link { get; set; }
        public int? Start { get; set; }
        public int? Limit { get; set; }



    }
}
