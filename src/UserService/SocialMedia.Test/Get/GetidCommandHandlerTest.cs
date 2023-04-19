using Microsoft.EntityFrameworkCore;
using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Querries.Get;
using UserService.Application.CQRS.Users.Querries.Get;

namespace SocialMedia.Test.Get
{
    [Collection("SocialMedias")]
    public class GetidCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetId()
        {
            var handler = new GetBySocialMediaHandler(_context);

            Guid guid0 = new Guid("cf995d9e-1fc1-411b-8039-a525de743eec");

            var socialmedia = await handler.Handle(
                new GetBySocialMediaQuerry()
                {
                    id = guid0,
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.id == guid0));
        }
    }
}
