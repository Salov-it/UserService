using Microsoft.EntityFrameworkCore;
using NickName.Test.Common;
using UserService.Application.CQRS.Querries.GetByUserIdQuerry;
using UserService.Application.CQRS.Querries.NickName.GetByUserIdQuerry;

namespace NickName.Test.GetById
{
    [Collection("NickNames")]
    public class GetByIdCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetByIdSucces()
        {
            Guid guid = new Guid("4d4c4544-0100-0100-8044-c7c04f533533");
            var handler = new GetByNickNameIdHandler(_context);

            var nicknames = await handler.Handle(
                new GetByNickNameIdQuerry()
                {
                    Id = guid
                },
                CancellationToken.None
            );
            Assert.NotNull(await _context.users.SingleOrDefaultAsync(w => w.id == guid));
        }
    }
}
