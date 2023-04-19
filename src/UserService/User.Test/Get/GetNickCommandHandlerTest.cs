using Microsoft.EntityFrameworkCore;
using User.Test.Common;
using UserService.Application.CQRS.Users.Querries.Get;

namespace User.Test.Get
{
 
    public class GetNickCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetNick()
        {
            var handler = new GetHandler(_context);

            var users = await handler.Handle(
                new GetQuerry()
                {
                    Nick = "text3"
                },
                CancellationToken.None
            );
            Assert.Equal(users[0].id, ContextFactory.guid1);
        }
    }
}
