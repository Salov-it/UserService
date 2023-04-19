using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMediaTypes.Querries.Get
{
    public class GetBySocialMediaTypesQuerry : IRequest<SocialMediaType[]>
    {
        public Guid? id { get; set; }
        public string value { get; set; }
        public int? Limit { get; set; }
        public string OrderBy { get; set; }
        public string OrderType { get; set; }
        public int? Start { get; set; }
    }
}
