using UserService.Infrastructure;

namespace User.Test.Common
{
    public class Base : IDisposable
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
