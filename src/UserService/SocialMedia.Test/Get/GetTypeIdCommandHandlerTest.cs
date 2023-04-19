using Microsoft.EntityFrameworkCore;
using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Querries.Get;

namespace SocialMedia.Test.Get
{
    [Collection("SocialMedias")]
    public class GetTypeIdCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetTypeId()
        {
            var handler = new GetBySocialMediaHandler(_context);

            Guid guid7 = new Guid("4d4c4544-0100-0100-8044-c7c04f533538");

            var socialmedia = await handler.Handle(
                new GetBySocialMediaQuerry()
                {
                   typeId = guid7
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.typeId == guid7));
        }
    }
}
