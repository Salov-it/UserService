using MediatR;
using Microsoft.EntityFrameworkCore;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMedias.Querries.GetBySocialMediaIdQuerry
{
    public class GetBySocialMediaIdHandler : IRequestHandler<GetBySocialMediaIdQuerry, SocialMedia>
    {
        private readonly IContext _Context;
        public GetBySocialMediaIdHandler(IContext Context)
        {
            _Context = Context;
        }
        public async Task<Domain.SocialMedia> Handle(GetBySocialMediaIdQuerry request, CancellationToken cancellationToken)
        {
            return await _Context.SocialMedias.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
