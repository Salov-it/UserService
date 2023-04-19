using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMedias.Querries.GetBySocialMediaIdQuerry
{
    public class GetBySocialMediaIdQuerry : IRequest<SocialMedia>
    {
        public Guid Id { get; set; }
    }
}
