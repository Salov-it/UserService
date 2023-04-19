

namespace UserService.Infrastructure
{
    public class DbInit
    {
        public static void init(Context context)
        {
            context.Database.EnsureCreated();
        }
    }
}
