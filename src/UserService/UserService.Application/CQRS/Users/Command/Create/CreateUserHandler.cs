using MediatR;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.Users.Command.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserСommand, User>
    {
        public CreateUserHandler(IContext context)
        {
            _Context = context;
        }
        private readonly IContext _Context;
        public async Task<User> Handle(CreateUserСommand request, CancellationToken cancellationToken)
        {

            var content = new User
            {
                refferalId = request.refferalId,
                ownerId = request.ownerId,
                nick = request.nick,
                link = request.link,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now
            };

            await _Context.Users.AddAsync(content, cancellationToken);
            await _Context.SaveChangesAsync(cancellationToken);

            return content;
        }
    }
}
