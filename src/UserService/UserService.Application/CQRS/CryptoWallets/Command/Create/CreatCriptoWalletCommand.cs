using MediatR;
using UserService.Domain;

namespace UserService.Application.CQRS.CryptoWallets.Command.Create
{
    internal class CreatCriptoWalletCommand : IRequest<CryptoWallet>
    {
        public int AccountId { get; set; }
        public string Hash { get; set; }
        public string Address { get; set; }
    }
}
