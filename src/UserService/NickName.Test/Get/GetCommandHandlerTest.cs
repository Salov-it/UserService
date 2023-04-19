using NickName.Test.Common;
using UserService.Application.CQRS.NickName.Querries.Get;
using UserService.Application.CQRS.Querries.Get;

namespace NickName.Test.Get
{
    [Collection("NickNames")]
    public class GetCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetSucces()
        {
            var handler = new GetByNickNameHandler(_context);

            var nicknames = await handler.Handle(
                new GetByNickNameQuerry()
                {

                },
                CancellationToken.None
            );

            Assert.NotNull(_context.Nickname.ToList());
        }
    }
}
