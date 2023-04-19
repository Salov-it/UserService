using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMediaTypes.Command.Create
{
    public class CreateSocialMediaTypesСommand : IRequest<SocialMediaType>
    { 
      public string value { get; set; }
    }
}
