using SocialMediaType.Test.Common;
using UserService.Application.CQRS.SocialMediaTypes.Querries.Get;

namespace SocialMediaType.Test.Get
{
    [Collection("SocialMediaTypes")]
    public class GetCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetSucces()
        {
            var handler = new GetBySocialMediaTypesHandler(_context);

            var socialmediatypes = await handler.Handle(
                new GetBySocialMediaTypesQuerry()
                {

                },
                CancellationToken.None
            );

            Assert.NotNull(_context.SocialMediatypes.ToList());
        }
    }
}
