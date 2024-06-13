using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.Equipments.Commands.CreateEquipment;
using Project01.Application.Features.Equipments.Commands.DeleteEquipment;
using Project01.Application.Features.Equipments.Commands.UpdateEquipment;
using Project01.Application.Features.Equipments.Queries.GetAllEquipment;
using Project01.Core.Common.Filters;

namespace Project01.Core.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [TypeFilter(typeof(UserAutentificationFilter))]
    public class EquipmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EquipmentController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllEquipment()
        {
            var result = await _mediator.Send(new GetAllEquipmentQuery());
            return Ok(result);
        }


        [HttpPost("create")]
        public async Task<ActionResult> CreateEquipment([FromBody] CreateEquipmentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateEquipment([FromBody] UpdateEquipmentCommand command)
        {
            await _mediator.Send(command);

            return Ok("Успешно изменен");
        }


        [HttpPost("delete")]
        public async Task<IActionResult> DeleteEquipment(Guid id)
        {
            await _mediator.Send(new DeleteEquipmentCommand { Id = id });

            return Ok("Успешно удалён");
        }
    }
}
