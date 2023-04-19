using Microsoft.EntityFrameworkCore;
using UserService.Domain;
using UserService.Infrastructure;

namespace NickName.Test.Common
{
    public class ContextFactory
    {
        static Guid guid = new Guid("4d4c4544-0100-0100-8044-c7c04f533533");
        public static Context Create()
        {
            var opt = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase("1")
                .Options;
            var context = new Context(opt);
            context.Database.EnsureCreated();

            context.Nickname.AddRange(
                getNickNames()
                );
            return context;
        }

        public static void Destroy(Context context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
        
        
        public static NickNames[] getNickNames()
        {
            var nickname = new NickNames[]
            {

                new NickNames()
                {
                    ownerId = 1,
                    nick = "text1",
                    link = "text1",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                
                new NickNames()
                {
                    id = guid,
                    ownerId = 2,
                    nick = "text2",
                    link = "text2",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                }
            };
            return nickname;
        }
    }
}
