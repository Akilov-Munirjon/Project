using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.Users.Commands.CreateUser;
using Project01.Application.Features.Users.Commands.DeleteUser;
using Project01.Application.Features.Users.Commands.UpdateUser;
using Project01.Application.Features.Users.Queries;
using Project01.Core.Common.Filters;

namespace Project01.Core.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [TypeFilter(typeof(UserAutentificationFilter))]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _mediator.Send(new GetAllUserQuery());
            return Ok(result);
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
        {
            await _mediator.Send(command);
            return Ok("Успешно изменен");
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            await _mediator.Send(new DeleteUserCommand { Id = id });
            return Ok("Успешно удален");
        }
    }
}
