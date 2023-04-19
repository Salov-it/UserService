using MediatR;
using Microsoft.EntityFrameworkCore;
using UserService.Application.Interface;
using UserService.Domain;


namespace UserService.Application.CQRS.SocialMediaTypes.Querries.Get
{
    public class GetBySocialMediaTypesHandler : IRequestHandler<GetBySocialMediaTypesQuerry, SocialMediaType[]>
    {
        private readonly IContext _context;
        public GetBySocialMediaTypesHandler(IContext context)
        {
            _context = context;
        }
       
      public async Task<Domain.SocialMediaType[]> Handle(GetBySocialMediaTypesQuerry request, CancellationToken cancellationToken)
      {
            var socialmediatypes = _context.SocialMediatypes.AsQueryable();
            if (request.id != null)
            {
                socialmediatypes = socialmediatypes.Where(u => u.id == request.id);
            }
            if (request.value != null)
            {
                socialmediatypes = socialmediatypes.Where(u => u.value == request.value);
            }
            
            if (request.OrderBy != null)
            {
                var orderByProperty = typeof(User).GetProperty(request.OrderBy);
                if (orderByProperty != null)
                {
                    socialmediatypes = request.OrderType == "asc" ? socialmediatypes.OrderBy(u => orderByProperty.GetValue(u)) :
                                                                   socialmediatypes.OrderByDescending(u => orderByProperty.GetValue(u));
                }
            }

            if (request.Start != null)
            {
                socialmediatypes = socialmediatypes.Skip((int)request.Start);
            }
            if (request.Limit != null)
            {
                socialmediatypes = socialmediatypes.Take((int)request.Limit);
            }

            return await socialmediatypes.ToArrayAsync();
        }
    }
}
