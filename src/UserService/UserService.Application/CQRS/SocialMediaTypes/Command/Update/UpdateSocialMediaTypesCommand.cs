using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMediaTypes.Command.Update
{
    public class UpdateSocialMediaTypesCommand : IRequest<SocialMediaType>
    {
        public Guid Id { get; set; }
        public string value { get; set; }
    }
}
