using MediatR;
using Microsoft.EntityFrameworkCore;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.Users.Querries.GetByUserIdQuerry
{
    public class GetByUserIdHandler : IRequestHandler<GetByUserIdQuerry, User>
    {
        private readonly IContext _Context;
        public GetByUserIdHandler(IContext Context)
        {
            _Context = Context;
        }
        public async Task<User> Handle(GetByUserIdQuerry request, CancellationToken cancellationToken)
        {
            return await _Context.Users.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
