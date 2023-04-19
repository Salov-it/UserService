using Microsoft.EntityFrameworkCore;
using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Command.Create;

namespace SocialMedia.Test.Creatu
{
    [Collection("SocialMedias")]
    public class CreateCommandHandlerTest : Base
    {
        [Fact]
        public async Task CreateSucces()
        {
            Guid guid = new Guid("4d4c4544-0100-0100-8044-c7c04f533539");
            var handler = new CreateSocialMediaHandler(_context);

            var socialmedia = await handler.Handle(
                new CreateSocialMediaСommand()
                {
                  link = "text3",
                  typeId = guid,
                  ownerId = 3
                },
                CancellationToken.None
            );
            Assert.NotNull(
                await _context.SocialMedias.SingleOrDefaultAsync(
                    w => w.id == w.id
                    && w.link == "text3"
                    && w.typeId == guid
                    && w.ownerId == 3));
        }
    }
}
