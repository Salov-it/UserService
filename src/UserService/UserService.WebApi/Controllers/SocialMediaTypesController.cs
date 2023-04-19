using Microsoft.AspNetCore.Mvc;
using UserService.Application.CQRS.SocialMediaTypes.Command.Create;
using UserService.Application.CQRS.SocialMediaTypes.Command.Update;
using UserService.Application.CQRS.SocialMediaTypes.Querries.Get;
using UserService.Application.CQRS.SocialMediaTypes.Querries.GetBySocialMediaTypeIdQuerry;
using UserService.Application.CQRS.Users.Querries.Get;

namespace UserService.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SocialMediaTypesController : BaseController
    {

        [HttpPost("create")]
        public async Task<IActionResult> create(string value)
        {
            var content = new CreateSocialMediaTypesСommand
            {
              value = value
            };
            var answer = await Mediator.Send(content);
            return Ok(answer);
        }

        [HttpPost("update")]
        public async Task<IActionResult> update(Guid id, string value)
        {
            var content = new UpdateSocialMediaTypesCommand
            {
                Id = id,
                value = value
            };

            var answer = await Mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> getbyid(Guid Id)
        {
            var content = new GetBySocialMediaTypesIdQuerry
            {
                Id = Id
            };
            var answer = await Mediator.Send(content);
            return Ok(answer);
        }


        [HttpGet("get")]
        public async Task<IActionResult> get(Guid? id, string? value,
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

            GetBySocialMediaTypesQuerry content = new()
            {
               id = id,
               value = value,
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
