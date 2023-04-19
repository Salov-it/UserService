using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMedias.Command.Create
{
    public class CreateSocialMediaСommand : IRequest<SocialMedia>
    {
        public string link { get; set; }
        public Guid typeId { get; set; }
        public int ownerId { get; set; }
    }
}
