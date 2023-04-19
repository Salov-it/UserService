using MediatR;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMediaTypes.Command.Update
{
    public class UpdateSocialMediaTypesHandler : IRequestHandler<UpdateSocialMediaTypesCommand, SocialMediaType>
    {
        private readonly IContext _context;
        public UpdateSocialMediaTypesHandler(IContext context)
        {
            _context = context;
        }
        public async Task<Domain.SocialMediaType> Handle(UpdateSocialMediaTypesCommand request, CancellationToken cancellationToken)
        {
            var content = await _context.SocialMediatypes.FindAsync(request.Id);
            
            content.value = request.value;
            content.updatedAt = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);
            return content;
        }
    }
}
