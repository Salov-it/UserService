using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UserService.Application.Interface;
using UserService.Domain;


namespace UserService.Application.CQRS.SocialMedias.Querries.Get
{
    public class GetBySocialMediaHandler : IRequestHandler<GetBySocialMediaQuerry, SocialMedia[]>
    {
        private readonly IContext _context;
        public GetBySocialMediaHandler(IContext context)
        {
            _context = context;
        }
        public async Task<Domain.SocialMedia[]> Handle(GetBySocialMediaQuerry request, CancellationToken cancellationToken)
        {
            var socialmedia = _context.SocialMedias.AsQueryable();
            if (request.id != null)
            {
                socialmedia = socialmedia.Where(u => u.id == request.id);
            }
            if (request.typeId != null)
            {
                socialmedia = socialmedia.Where(u => u.typeId == request.typeId);
            }
            if (request.ownerId != null)
            {
                socialmedia = socialmedia.Where(u => u.ownerId == request.ownerId);
            }
           
            if (!string.IsNullOrWhiteSpace(request.link))
            {
                socialmedia = socialmedia.Where(u => u.link == request.link);
            }
            if (request.OrderBy != null)
            {
                var orderByProperty = typeof(User).GetProperty(request.OrderBy);
                if (orderByProperty != null)
                {
                    socialmedia = request.OrderBy == "asc" ? socialmedia.OrderBy(u => orderByProperty) :
                                                                    socialmedia.OrderByDescending(u => orderByProperty);
                }
            }

            if (request.Start != null)
            {
                socialmedia = socialmedia.Skip((int)request.Start);
            }
            if (request.Limit != null)
            {
                socialmedia = socialmedia.Take((int)request.Limit);
            }

            return await socialmedia.ToArrayAsync();
        }
    }
}
