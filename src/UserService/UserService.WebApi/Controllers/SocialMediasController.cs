using Microsoft.AspNetCore.Mvc;
using UserService.Application.CQRS.SocialMedias.Command.Create;
using UserService.Application.CQRS.SocialMedias.Command.Update;
using UserService.Application.CQRS.SocialMedias.Querries.Get;
using UserService.Application.CQRS.SocialMedias.Querries.GetBySocialMediaIdQuerry;
using UserService.Application.CQRS.Users.Querries.Get;

namespace UserService.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SocialMediasController : BaseController
    {

        [HttpPost("create")]
        public async Task<IActionResult> create(Guid typeId,int ownerId, string link)
        {
            var content = new CreateSocialMediaСommand
            {
                typeId = typeId,
                ownerId = ownerId,
                link = link
            };
            var answer = await Mediator.Send(content);
            return Ok(answer);
        }

        [HttpPost("update")]
        public async Task<IActionResult> update(Guid id,Guid typeId, int ownerId, string link)
        {
            var content = new UpdateSocialMediaCommand
            {
                Id = id,
                typeId = typeId,
                ownerId = ownerId,
                link = link
            };

            var answer = await Mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> getbyid(Guid Id)
        {
            var content = new GetBySocialMediaIdQuerry
            {
                Id = Id
            };
            var answer = await Mediator.Send(content);
            return Ok(answer);
        }


        [HttpGet("get")]
        public async Task<IActionResult> get(Guid? id,Guid? typeId,
                                                int? owner_id,string? link,
                                                string? order_by, string? order_type, int? start, int? limit)
        {
            //var identity = await IdetityClient.GetRolesAsync(HttpContext.Request.Headers.Authorization);
            //if (identity == null) 
            //{
            //    return Unauthorized();
            //}
            if (string.IsNullOrWhiteSpace(order_type))
            {
                order_type = "asc";
            }

            GetBySocialMediaQuerry content = new()
            {
               id = id,
               ownerId = owner_id,
               typeId = typeId,
               link = link,
               OrderBy = order_by,
               OrderType = order_type,
               Limit = limit,
               Start = start
            };
            var answer = await Mediator.Send(content);
            return Ok(answer);
        }

    }
}
