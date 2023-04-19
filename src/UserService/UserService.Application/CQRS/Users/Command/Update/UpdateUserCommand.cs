using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.Users.Command.Update
{
    public class UpdateUserCommand : IRequest<User>
    {
        public Guid id { get; set; }
        public int refferalId { get; set; }
        public int ownerId { get; set; }
        public string nick { get; set; }
        public string link { get; set; }
    }
}
