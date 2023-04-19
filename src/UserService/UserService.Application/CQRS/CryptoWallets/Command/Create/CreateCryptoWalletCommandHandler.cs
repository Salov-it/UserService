using UserService.Domain;
using MediatR;
using UserService.Application.Interface;
using Microsoft.EntityFrameworkCore;

namespace UserService.Application.CQRS.CryptoWallets.Command.Create
{
    //internal class CreateCryptoWalletCommandHandler : IRequestHandler<CreatCriptoWalletCommand, CryptoWallet>
    //{
    //    private readonly IContext context;
    //    private readonly IEthers ethers;
    //    public CreateCryptoWalletCommandHandler(IContext context, IEthers ethers)
    //    {
    //        this.context = context;
    //        this.ethers = ethers;
    //    }

    //    public async Task<CryptoWallet> Handle(CreatCriptoWalletCommand request, CancellationToken cancellationToken)
    //    {
    //        var wallet = await context.CryptoWallets.FirstOrDefaultAsync(c => c.Address == request.Address && c.AccountId == request.AccountId);
    //        if (wallet == null) 
    //        {
    //            var id = ethers.GetId(request.Address);
    //            var hash = ethers.GetHash(request.Address, id);
    //            if (hash != request.Hash) 
    //            {
    //                /// EXCHEPTION!!!!!!!!!
    //            }
    //            else
    //            {
    //                wallet = new CryptoWallet
    //                {
    //                    Id = Guid.NewGuid(),
    //                    AccountId = request.AccountId,
    //                    Hash = hash,
    //                    Address = request.Address
    //                };
    //                await context.CryptoWallets.AddAsync(wallet);
    //                await context.SaveChangesAsync(cancellationToken);
    //                return wallet;
    //            }
    //        }
    //        else
    //        {
    //            /// EXCEPTION!!!!!!!!!!!!!!!!!
    //        }
    //        return wallet; 
    //    }
    }

