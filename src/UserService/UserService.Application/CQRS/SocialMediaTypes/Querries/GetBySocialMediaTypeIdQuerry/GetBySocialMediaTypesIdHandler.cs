using MediatR;
using Microsoft.EntityFrameworkCore;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMediaTypes.Querries.GetBySocialMediaTypeIdQuerry
{
    public class GetBySocialMediaTypesIdHandler : IRequestHandler<GetBySocialMediaTypesIdQuerry, SocialMediaType>
    {
        private readonly IContext _Context;
        public GetBySocialMediaTypesIdHandler(IContext Context)
        {
            _Context = Context;
        }
        public async Task<Domain.SocialMediaType> Handle(GetBySocialMediaTypesIdQuerry request, CancellationToken cancellationToken)
        {
            return await _Context.SocialMediatypes.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
