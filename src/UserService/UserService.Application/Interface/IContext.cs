using Microsoft.EntityFrameworkCore;
using UserService.Domain;

namespace UserService.Application.Interface
{
    public interface IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<SocialMediaType> SocialMediatypes { get; set; }
        public DbSet<CryptoWallet> CryptoWallets { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
