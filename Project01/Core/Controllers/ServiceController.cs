using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.Services.Command;
using Project01.Application.Features.Services.Command.DeleteService;
using Project01.Application.Features.Services.Command.UpdateService;
using Project01.Application.Features.Services.Queries.GetAllServices;

namespace Project01.Core.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServices()
        {
            var result = await _mediator.Send(new GetAllServiceQuery());
            return Ok(result);
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateService([FromBody] CreateServiceCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateService([FromBody] UpdateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Успешно изменено");
        }


        [HttpPost("delete")]
        public async Task<IActionResult> DeleteService(Guid id)
        {
            await _mediator.Send(new DeleteServiceCommand { Id = id });
            return Ok("Успешно удалено");
        }
    }
}
