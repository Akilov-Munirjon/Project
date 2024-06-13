using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.ServicesEquipments.Queries.GetServiceEquipments;
using Project01.Application.Features.ServicesEquipments.Commands.CreateServiceEquipment;
using Project01.Application.Features.ServicesEquipments.Commands.UpdateServiceEquipment;
using Project01.Application.Features.ServicesEquipments.Commands.DeleteServicesEquipment;
using Project01.Core.Common.Filters;

namespace Project01.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [TypeFilter(typeof(UserAutentificationFilter))]
    public class ServiceEquipmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceEquipmentController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetServiceEquipment()
        {
            var result = await _mediator.Send(new GetServicesEquipmentsQuery());
            return Ok(result);
        }



        [HttpPost("create")]
        public async Task<IActionResult> AddServiceEquipment([FromBody] CreateServicesEquipmentsCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateServiceEquipment([FromBody] UpdateServiceEquipmentCommand command)
        {
            await _mediator.Send(command);

            return Ok("Успешно изменен");
        }


        [HttpPost("delete")]
        public async Task<IActionResult> DeleteServiceEquipment(Guid id)
        {
            await _mediator.Send(new DeleteServicesEquipmentsCommand { Id = id });
            return Ok("Успешно удалено");
        }

    }
}
