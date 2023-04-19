using Microsoft.EntityFrameworkCore;
using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Querries.Get;

namespace SocialMedia.Test.Get
{
    [Collection("SocialMedias")]
    public class GetStartCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetStart()
        {
            var handler = new GetBySocialMediaHandler(_context);

             Guid guid4 = new Guid("4d4c4544-0100-0100-8044-c7c04f533535");
             Guid guid5 = new Guid("4d4c4544-0100-0100-8044-c7c04f533536");
             Guid guid6 = new Guid("4d4c4544-0100-0100-8044-c7c04f533537");

            var socialmedia = await handler.Handle(
                new GetBySocialMediaQuerry()
                {
                   Start = 3
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.id == guid4));
            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.id == guid5));
            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.id == guid6));
        }
    }
}
