using UserService.Infrastructure;

namespace SocialMedia.Test.Common
{
    public class Base
    {
        protected readonly Context _context;

        public Base()
        {
            _context = ContextFactory.Create();
        }
        public void Dispose()
        {
            ContextFactory.Destroy(_context);
        }
    }
}
