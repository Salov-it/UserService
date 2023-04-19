using MediatR;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.Users.Command.Update
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, User>
    {
        private readonly IContext _context;
        public UpdateUserHandler(IContext context)
        {
            _context = context;
        }
        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var content = await _context.Users.FindAsync(request.id);

            content.refferalId = request.refferalId;
            content.ownerId = request.ownerId;
            content.nick = request.nick;
            content.link = request.link;
            content.updatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
            return content;
        }
    }
}
