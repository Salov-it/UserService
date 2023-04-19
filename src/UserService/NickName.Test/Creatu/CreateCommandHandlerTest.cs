using Microsoft.EntityFrameworkCore;
using NickName.Test.Common;
using UserService.Application.CQRS.NickName.Command.Create;

namespace NickName.Test.Creatu
{
    [Collection("NickNames")]
    public class CreateCommandHandlerTest : Base
    {
        [Fact]
        public async Task CreateSucces()
        {
            var handler = new CreateNickNameHandler(_context);

            var users = await handler.Handle(
                new CreateNickNameСommand()
                {
                   ownerId = 3,
                   link = "text3",
                   nick = "text3"
                },
                CancellationToken.None
            );
            Assert.NotNull(
                await _context.Nickname.SingleOrDefaultAsync(
                    w => w.id == w.id
                    && w.ownerId == 3
                    && w.link == "text3"
                    && w.nick == "text3"));
        }
    }
}
