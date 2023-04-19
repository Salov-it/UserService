﻿using Microsoft.EntityFrameworkCore;
using SocialMedia.Test.Common;
using UserService.Application.CQRS.SocialMedias.Querries.Get;

namespace SocialMedia.Test.Get
{
    [Collection("SocialMedias")]
    public class GetOrderByCommandHandlerTest : Base
    {
        [Fact]
        public async Task GetOrderBy()
        {
            var handler = new GetBySocialMediaHandler(_context);

            Guid guid0 = new Guid("cf995d9e-1fc1-411b-8039-a525de743eec");
            Guid guid = new Guid("b7bd4c27-5cd8-4fc5-b34a-321487878ee0");
            Guid guid1 = new Guid("5ba1cd9b-0e7d-4cf1-9834-04d1381c1b1a");

            var socialmedia = await handler.Handle(
                new GetBySocialMediaQuerry()
                {
                    OrderBy = "asc"
                },
                CancellationToken.None
            );

            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.id == guid0));
            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.id == guid));
            Assert.NotNull(await _context.SocialMedias.SingleOrDefaultAsync(w => w.id == guid1));

        }
    }
}
