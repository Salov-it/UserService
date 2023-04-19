using Microsoft.EntityFrameworkCore;
using SocialMediaType.Test.Common;
using UserService.Application.CQRS.SocialMediaTypes.Querries.Get;
using UserService.Application.CQRS.Users.Querries.Get;

namespace SocialMediaType.Test.Get
{
    [Collection("SocialMediaTypes")]
    public class GetvalueCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetValue()
        {
            var handler = new GetBySocialMediaTypesHandler(_context);

            Guid guid0 = new Guid("4d4c4544-0100-0100-8044-c7c04f533530");

            var socialmediamypes = await handler.Handle(
                new GetBySocialMediaTypesQuerry()
                {
                  value = "text3"
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMediatypes.FirstOrDefaultAsync(w => w.value == "text3"));
        }
    }
}
