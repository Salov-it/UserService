using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Querries.Get;

namespace SocialMedia.Test.Get
{
    [Collection("SocialMedias")]
    public class GetCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetSucces()
        {
            var handler = new GetBySocialMediaHandler(_context);

            var socialmedias = await handler.Handle(
                new GetBySocialMediaQuerry()
                {

                },
                CancellationToken.None
            );

            Assert.NotNull(_context.SocialMedias.ToList());
        }
    }
}
