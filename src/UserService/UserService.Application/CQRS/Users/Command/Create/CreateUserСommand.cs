using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.Users.Command.Create
{
    public class CreateUserСommand : IRequest<User>
    {
        public int refferalId { get; set; }
        public int ownerId { get; set; }
        public string nick { get; set; }
        public string link { get; set; }
    }
}
