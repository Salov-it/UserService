using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.SocialMedias.Querries.Get
{
    public class GetBySocialMediaQuerry : IRequest<SocialMedia[]>
    {
        public Guid? id { get; set; }
        public string link { get; set; }
        public Guid? typeId { get; set; }
        public int? ownerId { get; set; }
        public string OrderBy { get; set; }
        public string OrderType { get; set; }
        public int? Start { get; set; }
        public int? Limit { get; set; }
    }
}
