using Microsoft.EntityFrameworkCore;
using User.Test.Common;
using UserService.Application.CQRS.Users.Querries.Get;

namespace User.Test.Get
{
   
    public class GetRefferalIdCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetRefferalId()
        {
            var handler = new GetHandler(_context);

            var users = await handler.Handle(
                new GetQuerry()
                {
                    RefferalId = 1
                },
                CancellationToken.None
            );

            Assert.Equal(users.Length, 2 );
            Assert.Equal(users[0].id, ContextFactory.guid0);
            Assert.Equal(users[1].id, ContextFactory.guid4);
        }
    }
}
