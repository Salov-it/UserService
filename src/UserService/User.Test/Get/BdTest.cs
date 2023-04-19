using Microsoft.EntityFrameworkCore;
using User.Test.Common;

namespace User.Test.Get
{
    public class BdTest : Base
    {
          [Fact]
            public async Task GetBD()
            {
                var users = await _context.Users.ToArrayAsync();
                Assert.Equal(10, users.Length);
            }
        
    }
}
