using Microsoft.AspNetCore.Mvc;
using UserService.Application.CQRS.Users.Command.Create;
using UserService.Application.CQRS.Users.Command.Update;
using UserService.Application.CQRS.Users.Querries.Get;

namespace UserService.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {

        [HttpPost("create")]
        public async Task<IActionResult> create(int accountId, int refferalId,int ownerId, string nick,string link)
        {
            var content = new CreateUserСommand
            {
               refferalId = refferalId,
               ownerId = ownerId,
               nick = nick,
               link = link
            };
            var answer = await Mediator.Send(content);
            return Ok(answer);
        }

        [HttpPut("update")]
        public async Task<IActionResult> update(Guid id,int accountId, int refferalId, int ownerId, string nick, string link)
        {
            var content = new UpdateUserCommand
            {
               id = id,
               refferalId = refferalId,
               ownerId = ownerId,
               nick = nick,
               link = link
            };

            var answer = await Mediator.Send(content);
            return Ok(answer);
        }



        
        [HttpGet("get")]
        public async Task<IActionResult> get(Guid? id, int? refferal_id,int? owner_id, string? nick, string? link, int? start, int? limit)
        {
            //var identity = await IdetityClient.GetRolesAsync(HttpContext.Request.Headers.Authorization);
            //if (identity == null) 
            //{
            //    return Unauthorized();
            //}
            

            GetQuerry content = new()
            {
                Id = id,
                Limit = limit,
                Link = link,
                Start = start,
                Nick = nick,
                OwnerId = owner_id,
                RefferalId = refferal_id,
            };
            var answer = await Mediator.Send(content);
            return Ok(answer);
        }
    }
}
