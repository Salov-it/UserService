
namespace UserService.Domain
{
    public class CryptoWallet
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public string Address { get; set; }
        public string Hash { get; set; }
    }
}
