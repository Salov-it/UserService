using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMediaTypes.Querries.GetBySocialMediaTypeIdQuerry
{
    public class GetBySocialMediaTypesIdQuerry : IRequest<SocialMediaType>
    {
        public Guid Id { get; set; }
    }
}
