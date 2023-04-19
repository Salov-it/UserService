using Microsoft.EntityFrameworkCore;
using User.Test.Common;
using UserService.Application.CQRS.Users.Querries.Get;

namespace User.Test.Get
{
    
    public class GetStartCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetStart()
        {
            var handler = new GetHandler(_context);

            var users = await handler.Handle(
                new GetQuerry()
                {
                    Start = 0
                },
                CancellationToken.None
            );

            Assert.Equal(10,users.Length);

            
            var handler2 = new GetHandler(_context);

            var users2 = await handler2.Handle(
                new GetQuerry()
                {
                    Start = 9
                },
                CancellationToken.None
            );

            Assert.Single(users2);
        }
    }
}
