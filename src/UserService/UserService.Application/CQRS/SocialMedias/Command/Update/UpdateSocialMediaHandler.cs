using MediatR;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMedias.Command.Update
{
    public class UpdateSocialMediaHandler : IRequestHandler<UpdateSocialMediaCommand, SocialMedia>
    {
        private readonly IContext _context;
        public UpdateSocialMediaHandler(IContext context)
        {
            _context = context;
        }
        public async Task<Domain.SocialMedia> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var content = await _context.SocialMedias.FindAsync(request.Id);

            content.link = request.link;
            content.typeId = request.typeId;
            content.ownerId = request.ownerId;
            content.updatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
            return content;
        }
    }
}
