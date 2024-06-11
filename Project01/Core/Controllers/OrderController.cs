using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project01.Application.Features.Orders.Commands.CreateOrder;
using Project01.Application.Features.Orders.Commands.DeleteOrder;
using Project01.Application.Features.Orders.Commands.UpdateOrder;
using Project01.Application.Features.Orders.Queries.GetAllOrders;
using Project01.Application.Features.Orders.Queries.GetOrderReport;

namespace Project01.Core.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var result = await _mediator.Send(new GetAllOrderQuery());
            return Ok(result);
        }

        [HttpGet("report")]
        public async Task<IActionResult> GetOrderReport(int reportType)
        {
            var data = await _mediator.Send(new GetOrderReportQuery
            {
                ReportType = reportType
            });

            return Ok(data);
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }


        [HttpPost("update")]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderCommand command)
        {
            await _mediator.Send(command);

            return Ok("Успешно изменен");
        }



        [HttpPost("delete")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            await _mediator.Send(new DeleteOrderCommand { Id = id });

            return Ok("Успешно удалён");
        }


    }
}
