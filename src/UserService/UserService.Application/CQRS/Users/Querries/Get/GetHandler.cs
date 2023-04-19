using MediatR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UserService.Application.Interface;
using UserService.Domain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace UserService.Application.CQRS.Users.Querries.Get
{
    public class GetHandler : IRequestHandler<GetQuerry, User[]>
    {
        private readonly IContext _context;
        public GetHandler(IContext context)
        {
            _context = context;
        }
        public async Task<User[]> Handle(GetQuerry request, CancellationToken cancellationToken)
        {
            var users = _context.Users.AsQueryable();
            if (request.Id != null) 
            {
                users = await Task.Run(() => users.Where(u => u.id == request.Id));
            }
            if (request.RefferalId != null)
            {
                users = await Task.Run(() => users.Where(u => u.refferalId == request.RefferalId));
            }
            if (request.OwnerId != null)
            {
                users = await Task.Run(() => users.Where(u => u.ownerId == request.OwnerId));
            }
            if (!string.IsNullOrWhiteSpace(request.Nick))
            {
                users = await Task.Run(() => users.Where(u => u.nick == request.Nick));
            }
            if (!string.IsNullOrWhiteSpace(request.Link))
            {
                users = await Task.Run(() => users.Where(u => u.link == request.Link));
            }

            if (request.Start != null)
            {
                users = await Task.Run(() => users.Skip((int)request.Start));
            }
            if (request.Limit != null)
            {
                users = await Task.Run(() => users.Take((int)request.Limit));
            }

            return await users.ToArrayAsync();
        }
    }
}
