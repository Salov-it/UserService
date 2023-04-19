using Microsoft.EntityFrameworkCore;
using UserService.Infrastructure;

namespace User.Test.Common
{
    public class ContextFactory 
    {
        static public Guid guid0;
        static public Guid guid;
        static public Guid guid1;
        static public Guid guid2;
        static public Guid guid3;
        static public Guid guid4;
        static public Guid guid5;
        static public Guid guid6;
        static public Guid guid7;
        static public Guid guid8;


        public static Context Create()
        {
            var opt = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new Context(opt);

            context.Database.EnsureCreated();

            var users = GetUsers();
            context.Users.AddRange(
                users
                );
            context.SaveChanges();

            SetUsers(users);
            return context;
        }

        public static void Destroy(Context context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
        
        
        private static UserService.Domain.User[] GetUsers()
        {
            var users = new UserService.Domain.User[]
            {
                new UserService.Domain.User()
                {
   
                    refferalId = 1,
                    ownerId = 1,
                    nick = "12",
                    link = "12",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 3,
                    ownerId = 2,
                    nick = "text2",
                    link = "text2",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 3,
                    ownerId = 3,
                    nick = "text3",
                    link = "text3",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {              
                    refferalId = 6,
                    ownerId = 4,
                    nick = "text4",
                    link = "text4",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 10,
                    ownerId = 5,
                    nick = "55",
                    link = "55",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 1,
                    ownerId = 6,
                    nick = "66",
                    link = "66",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 5,
                    ownerId = 7,
                    nick = "77",
                    link = "77",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 3,
                    ownerId = 8,
                    nick = "88",
                    link = "88",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 3,
                    ownerId = 9,
                    nick = "881",
                    link = "881",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                new UserService.Domain.User()
                {
                    refferalId = 5,
                    ownerId = 10,
                    nick = "txt",
                    link = "xtx",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
            };
            return users;
        }
        private static void SetUsers (UserService.Domain.User[] users) 
        {
            guid0 = users[0].id;
            guid = users[1].id;
            guid1 = users[2].id;
            guid2 = users[3].id;
            guid3 = users[4].id;
            guid4 = users[5].id;
            guid5 = users[6].id;
            guid6 = users[7].id;
            guid7 = users[8].id;
            guid8 = users[9].id;
        }
    }
}
