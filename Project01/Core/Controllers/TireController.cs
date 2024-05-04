using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.Tires.Commands.CreateTire;
using Project01.Application.Features.Tires.Commands.DeleteTire;
using Project01.Application.Features.Tires.Commands.UpdateTire;
using Project01.Application.Features.Tires.Queries.GetAllTires;

namespace Project01.Core.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TireController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TireController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> GetAllTires()
        {
            var result = await _mediator.Send(new GetAllTireQuery());

            return Ok(result);
        }

        
        [HttpPost("create")]
        public async Task<IActionResult> CreateTire([FromBody] CreateTireCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateTire([FromBody] UpdateTireCommand command)
        {
            await _mediator.Send(command);

            return Ok("Успешно изменено");
        }


        [HttpPost("delete")]
        public async Task<IActionResult> DeleteTire(Guid id)
        {
            await _mediator.Send(new DeleteTireCommand { Id = id });

            return Ok("Успешно удалено");
        }
    }
}
