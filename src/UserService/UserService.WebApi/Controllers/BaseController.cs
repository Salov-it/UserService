using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserService.IdentityCommunication;

namespace UserService.WebApi.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IMediator mediator;
               
        protected IMediator Mediator => mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        private IdentityServerApiClient identityServerApiClient;
        protected IdentityServerApiClient IdetityClient => identityServerApiClient ??= HttpContext.RequestServices.GetService<IdentityServerApiClient>();

         
    }
}
