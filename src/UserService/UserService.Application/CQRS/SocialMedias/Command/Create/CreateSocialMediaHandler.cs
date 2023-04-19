using MediatR;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMedias.Command.Create
{
    public class CreateSocialMediaHandler : IRequestHandler<CreateSocialMediaСommand, SocialMedia>
    {
        public CreateSocialMediaHandler(IContext context)
        {
            _Context = context;
        }
        private readonly IContext _Context;
        public async Task<SocialMedia> Handle(CreateSocialMediaСommand request, CancellationToken cancellationToken)
        {
            var content = new SocialMedia
            {
                ownerId = request.ownerId,
                typeId = request.typeId,
                link = request.link,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now
            };

            await _Context.SocialMedias.AddAsync(content, cancellationToken);
            await _Context.SaveChangesAsync(cancellationToken);

            return content;
        }
    }
}
