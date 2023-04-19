using Microsoft.EntityFrameworkCore;
using SocialMediaType.Test.Common;
using UserService.Application.CQRS.SocialMediaTypes.Command.Create;

namespace SocialMediaType.Test.Creatu
{
    [Collection("SocialMediaTypes")]
    public class CreateCommandHandlerTest : Base
    {
        [Fact]
        public async Task CreateSucces()
        {
            var handler = new CreateSocialMediaTypesHandler(_context);

            var socialmediatypes = await handler.Handle(
                new CreateSocialMediaTypesСommand()
                {
                   value = "text3"
                },
                CancellationToken.None
            );
            Assert.NotNull(
                await _context.SocialMediatypes.FirstOrDefaultAsync(
                    w => w.id == w.id
                    && w.value == "text3"));
        }
    }
}
