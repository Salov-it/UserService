using Microsoft.EntityFrameworkCore;
using User.Test.Common;
using UserService.Application.CQRS.Users.Querries.Get;

namespace User.Test.Get
{
  
    public class GetLinkCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetLink()
        {
            var handler = new GetHandler(_context);

            var users = await handler.Handle(
                new GetQuerry()
                {
                   Link = "text2"
                },
                CancellationToken.None
            );

            Assert.Equal(users[0].id, ContextFactory.guid );
        }
    }
}
