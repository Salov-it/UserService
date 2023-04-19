using Microsoft.EntityFrameworkCore;
using SocialMediaType.Test.Common;
using UserService.Application.CQRS.SocialMediaTypes.Querries.Get;
using UserService.Application.CQRS.Users.Querries.Get;

namespace SocialMediaType.Test.Get
{
    [Collection("SocialMediaTypes")]
    public class GetidCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetId()
        {
            var handler = new GetBySocialMediaTypesHandler(_context);

            Guid guid0 = new Guid("cf995d9e-1fc1-411b-8039-a525de743eec");

            var socialmediamypes = await handler.Handle(
                new GetBySocialMediaTypesQuerry()
                {
                    id = guid0
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMediatypes.SingleOrDefaultAsync(w => w.id == guid0));
        }
    }
}
