using Microsoft.EntityFrameworkCore;
using UserService.Domain;
using UserService.Infrastructure;

namespace SocialMedia.Test.Common
{
    public class ContextFactory
    {
        static public readonly Guid guid0 = new Guid("cf995d9e-1fc1-411b-8039-a525de743eec");
        static public readonly Guid guid = new Guid("b7bd4c27-5cd8-4fc5-b34a-321487878ee0");
        static public readonly Guid guid1 = new Guid("5ba1cd9b-0e7d-4cf1-9834-04d1381c1b1a");
        static public readonly Guid guid2 = new Guid("ce314239-e41b-4945-9219-3c8ba5f89053");
        static public readonly Guid guid3 = new Guid("4d4c4544-0100-0100-8044-c7c04f533534");
        static public readonly Guid guid4 = new Guid("4d4c4544-0100-0100-8044-c7c04f533535");
        static public readonly Guid guid5 = new Guid("4d4c4544-0100-0100-8044-c7c04f533536");
        static public readonly Guid guid6 = new Guid("4d4c4544-0100-0100-8044-c7c04f533537");
        static public readonly Guid guid7 = new Guid("4d4c4544-0100-0100-8044-c7c04f533538");
        public static Context Create()
        {
            var opt = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase("1")
                .Options;
            var context = new Context(opt);
            context.Database.EnsureCreated();

            context.SocialMedias.AddRange(
                getSocialMedias()
                );
            return context;
        }

        public static void Destroy(Context context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
        
        
        public static UserService.Domain.SocialMedia[] getSocialMedias()
        {
            var socialmedia = new UserService.Domain.SocialMedia[]
            {

                new UserService.Domain.SocialMedia()
                {
                    id = guid0,
                    link = "text",
                    typeId = guid,
                    ownerId = 1,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                
                new UserService.Domain.SocialMedia()
                {
                    id = guid,
                    link = "text2",
                    typeId = guid7,
                    ownerId = 2,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },

                new UserService.Domain.SocialMedia()
                {
                    id = guid1,
                    link = "text2",
                    typeId = guid6,
                    ownerId = 4,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },

                new UserService.Domain.SocialMedia()
                {
                    id = guid2,
                    link = "text2",
                    typeId = guid6,
                    ownerId = 5,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },

                new UserService.Domain.SocialMedia()
                {
                    id = guid4,
                    link = "text2",
                    typeId = guid6,
                    ownerId = 6,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },

                new UserService.Domain.SocialMedia()
                {
                    id = guid5,
                    link = "text2",
                    typeId = guid6,
                    ownerId = 7,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },

                new UserService.Domain.SocialMedia()
                {
                    id = guid6,
                    link = "text2",
                    typeId = guid6,
                    ownerId = 8,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                }
            };
            return socialmedia;
        }
    }
}
