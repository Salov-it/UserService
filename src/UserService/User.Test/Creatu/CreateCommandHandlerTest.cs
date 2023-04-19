using Microsoft.EntityFrameworkCore;
using User.Test.Common;
using UserService.Application.CQRS.Users.Command.Create;

namespace User.Test.Creatu
{
    [Collection("Users")]
    public class CreateCommandHandlerTest : Base
    {
        [Fact]
        public async Task CreateSucces()
        {
            var handler = new CreateUserHandler(_context);

            var users = await handler.Handle(
                new CreateUserСommand()
                {
                   refferalId = 5,
                   ownerId = 5,
                   nick = "text5",
                   link = "text5"
                },
                CancellationToken.None
            );
            Assert.NotNull(
                await _context.Users.SingleOrDefaultAsync(
                    w => w.id == w.id
                    && w.refferalId == 5
                    && w.ownerId == 5
                    && w.nick == "text5"
                    && w.link == "text5"));
        }
    }
}
