using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.Disks.Commands.DeleteDisk;
using Project01.Application.Features.Disks.Commands.UpdateDisk;
using Project01.Application.Features.Disks.Queries.GetAllDisks;

namespace Project01.Core.Controllers
{
    [ApiController]
    //[ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class DiskController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DiskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDisks()
        {
            var result = await _mediator.Send(new GetAllDiskQuery());
            return Ok(result);
        }


        [HttpPost("create")]
        public async Task<ActionResult> CreateDisk([FromBody] CreateDiskCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateDisk([FromBody] UpdateDiskCommand command)
        {
            await _mediator.Send(command);

            return Ok("Успешно изменен");
        }


        [HttpPost("delete")]
        public async Task<IActionResult> DeleteDisk(Guid id)
        {
            await _mediator.Send(new DeleteDiskCommand { Id = id });

            return Ok("Успешно удалён");
        }
    }
}