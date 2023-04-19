using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.Users.Querries.GetByUserIdQuerry
{
    public class GetByUserIdQuerry : IRequest<User>
    {
        public Guid Id { get; set; }
    }
}
