using Microsoft.EntityFrameworkCore;
using User.Test.Common;
using UserService.Application.CQRS.Users.Querries.Get;

namespace User.Test.Get
{

    public class GetLimitCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetLimit()
        {
            var handler = new GetHandler(_context);
            var users = await handler.Handle(
                new GetQuerry()
                {
                    Limit = 3
                },
                CancellationToken.None
            );

            Assert.Equal(users[0].id, ContextFactory.guid0);
            Assert.Equal(users[1].id, ContextFactory.guid);
            Assert.Equal(users[2].id, ContextFactory.guid1);
        }
    }
}
