using UserService.Infrastructure;

namespace NickName.Test.Common
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
