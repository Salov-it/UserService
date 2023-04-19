using MediatR;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMediaTypes.Command.Create
{
    public class CreateSocialMediaTypesHandler : IRequestHandler<CreateSocialMediaTypesСommand, SocialMediaType>
    {
        public CreateSocialMediaTypesHandler(IContext context)
        {
            _Context = context;
        }
        private readonly IContext _Context;
        public async Task<Domain.SocialMediaType> Handle(CreateSocialMediaTypesСommand request, CancellationToken cancellationToken)
        {
            var content = new Domain.SocialMediaType
            {
                value = request.value,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now
            };

            await _Context.SocialMediatypes.AddAsync(content, cancellationToken);
            await _Context.SaveChangesAsync(cancellationToken);

            return content;
        }
    }
}
