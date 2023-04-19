using Microsoft.EntityFrameworkCore;
using User.Test.Common;
using UserService.Application.CQRS.Users.Querries.Get;

namespace User.Test.Get
{
 
    public  class GetIdCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetId()
        {
            var handler = new GetHandler(_context);

            var users = await handler.Handle(
                new GetQuerry()
                {
                   Id = ContextFactory.guid0
                },
                CancellationToken.None
            );
            Assert.Equal(users[0].id, ContextFactory.guid0);
        }
    }
}
