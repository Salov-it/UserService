using Microsoft.EntityFrameworkCore;
using SocialMediaType.Test.Common;
using UserService.Application.CQRS.SocialMediaTypes.Querries.Get;

namespace SocialMediaType.Test.Get
{
    [Collection("SocialMediaTypes")]
    public class GetStartCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetStart()
        {
            var handler = new GetBySocialMediaTypesHandler(_context);

             Guid guid4 = new Guid("4d4c4544-0100-0100-8044-c7c04f533535");
             Guid guid5 = new Guid("4d4c4544-0100-0100-8044-c7c04f533536");
             Guid guid6 = new Guid("4d4c4544-0100-0100-8044-c7c04f533537");


            var socialmediamypes = await handler.Handle(
                new GetBySocialMediaTypesQuerry()
                {
                    Limit = 3
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMediatypes.SingleOrDefaultAsync(w => w.id == guid4));
            Assert.NotNull(await _context.SocialMediatypes.SingleOrDefaultAsync(w => w.id == guid5));
            Assert.NotNull(await _context.SocialMediatypes.SingleOrDefaultAsync(w => w.id == guid6));
        }
    }
}
