using Microsoft.EntityFrameworkCore;
using UserService.Domain;
using UserService.Infrastructure;

namespace SocialMediaType.Test.Common
{
    public class ContextFactory
    {
        static public readonly Guid guid0 = new Guid("cf995d9e-1fc1-411b-8039-a525de743eec");
        static public readonly Guid guid = new Guid("b7bd4c27-5cd8-4fc5-b34a-321487878ee0");
        static public readonly Guid guid1 = new Guid("5ba1cd9b-0e7d-4cf1-9834-04d1381c1b1a");
        static public readonly Guid guid2 = new Guid("4d4c4544-0100-0100-8044-c7c04f533533");
        static public readonly Guid guid3 = new Guid("4d4c4544-0100-0100-8044-c7c04f533534");
        static public readonly Guid guid4 = new Guid("4d4c4544-0100-0100-8044-c7c04f533535");
        static public readonly Guid guid5 = new Guid("4d4c4544-0100-0100-8044-c7c04f533536");
        static public readonly Guid guid6 = new Guid("4d4c4544-0100-0100-8044-c7c04f533537");
       
        public static Context Create()
        {
            var opt = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase("1")
                .Options;
            var context = new Context(opt);
            context.Database.EnsureCreated();

            context.SocialMediatypes.AddRange(
                getSocialMediaTypes()
                );
            return context;
        }

        public static void Destroy(Context context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
        
        
        public static UserService.Domain.SocialMediaType[] getSocialMediaTypes()
        {
            var socialmediatypes = new UserService.Domain.SocialMediaType[]
            {

                new UserService.Domain.SocialMediaType()
                {   
                    id = guid0,
                    value = "text1",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },
                
                new UserService.Domain.SocialMediaType()
                {
                    id = guid,
                    value = "text2",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                },

                 new UserService.Domain.SocialMediaType()
                 { 
                    id = guid1,
                    value = "text3",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                 },

                  new UserService.Domain.SocialMediaType()
                  { 
                    id = guid2,
                    value = "text2",
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now
                  },

                   new UserService.Domain.SocialMediaType()
                   {
                     id = guid3,
                     value = "text2",
                     createdAt = DateTime.Now,
                     updatedAt = DateTime.Now
                   },

                    new UserService.Domain.SocialMediaType()
                    {

                      id = guid4,
                      value = "text2",
                      createdAt = DateTime.Now,
                      updatedAt = DateTime.Now
                    },

                     new UserService.Domain.SocialMediaType()
                     {
                        id = guid5,
                        value = "text2",
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                     },

                      new UserService.Domain.SocialMediaType()
                      {
                         id = guid6,
                         value = "text2",
                         createdAt = DateTime.Now,
                         updatedAt = DateTime.Now
                      }
            };
            return socialmediatypes;
        }
    }
}
