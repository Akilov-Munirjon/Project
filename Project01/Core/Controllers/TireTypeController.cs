using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.TireTypes.Queries.GetAllTireType;
using Project01.Application.Features.TireTypes.Commands.CreateTireType;
using Project01.Application.Features.TireTypes.Commands.UpdateTireType;
using Project01.Application.Features.TireTypes.Commands.DeleteTireType;

namespace Project01.Core.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class TireTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TireTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetTireTypeId()
        {
            var result = await _mediator.Send(new GetAllTireTypeQuery());

            return Ok(result);  
        }


        [HttpPost("create")]
        public async Task<ActionResult> GetTireTypeCreate([FromBody] CreateTireTypeCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> GetTireTypeUpdate([FromBody] UpdateTireTypeCommand command)
        {
            await _mediator.Send(command);

            return Ok("Успешно изменен");
        }


        [HttpPost("delete")]
        public async Task<IActionResult> GetTireTypeDelete(Guid id)
        {
            await _mediator.Send(new DeleteTireTypeCommand { Id = id });

            return Ok("Успешно удалён");
        }
    }
}


