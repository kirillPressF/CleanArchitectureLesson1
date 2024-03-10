
using CleanArchitectureLesson1.API.Contracts;
using CleanArchitectureLesson1.Application.Services;
using CleanArchitectureLesson1.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureLesson1.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult> GetById(Guid id)
        {

        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrderRequest orderRequest)
        {
            var order = new Order
            {
                Name = orderRequest.Name,
            };
            await _orderService.Create(order);
            return Ok();
        }
    }
}
