using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMedias.Command.Update
{
    public class UpdateSocialMediaCommand : IRequest<SocialMedia>
    {
        public Guid Id { get; set; }
        public string link { get; set; }
        public Guid typeId { get; set; }
        public int ownerId { get; set; }
    }
}
