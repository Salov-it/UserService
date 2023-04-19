using Microsoft.EntityFrameworkCore;
using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Querries.Get;

namespace SocialMedia.Test.Get
{
    [Collection("SocialMedias")]
    public class GetLinkCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetLink()
        {
            var handler = new GetBySocialMediaHandler(_context);

            var socialmedia = await handler.Handle(
                new GetBySocialMediaQuerry()
                {
                    link = "text3"
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.link == "text3"));
        }
    }
}
