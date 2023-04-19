using Microsoft.EntityFrameworkCore;
using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Querries.Get;

namespace SocialMedia.Test.Get
{
    [Collection("SocialMedias")]
    public class GetOwnerIdCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetOwnerId()
        {
            var handler = new GetBySocialMediaHandler(_context);

            var socialmedia = await handler.Handle(
                new GetBySocialMediaQuerry()
                {
                    ownerId = 4
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.ownerId == 4));
        }
    }
}
