using Microsoft.AspNetCore.Mvc;
using MediatR;
using Project01.Application.Features.DiskTypes.Commands.UpdateDiskType;
using Project01.Application.Features.DiskTypes.Commands.DeleteDiskType;
using Project01.Application.Features.DiskTypes.Commands;
using Project01.Application.Features.DiskTypes.Queries.GetAllDikType;
using Project01.Core.Common.Filters;

namespace Project01.Core.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [TypeFilter(typeof(UserAutentificationFilter))]
    public class DiskTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DiskTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetDiskTypeId()
        {
            var result = await _mediator.Send(new GetAllDiskTypeQuery());

            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult> GDiskTypeCreate([FromBody] CreateDiskTypeCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> GetDiskTypeUpdate([FromBody] UpdateDiskTypeCommand command)
        {
            await _mediator.Send(command);

            return Ok("Успешно изменен");
        }


        [HttpPost("delete")]
        public async Task<IActionResult> GetDiskTypeDelete(Guid id)
        {
            await _mediator.Send(new DeleteDiskTypeCommand { Id = id });

            return Ok("Успешно удалён");
        }
    }
}
