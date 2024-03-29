﻿using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using shop_app.contract.ServiceResults;
using shop_app.entity;
using shop_app.api.ControllerExtensions;
using shop_app.contract.Requests.Queries;
using shop_app.contract.Requests.Commands;
using Microsoft.AspNetCore.Authorization;
using shop_app.contract.dto;

namespace shop_app.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController: ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<OrderDto> _validator;
        private IConfiguration _config;

        public OrdersController(IMediator mediator, IValidator<OrderDto> validator, IConfiguration config)
        {
            _mediator = mediator;
            _validator = validator;
            _config = config;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            var result = await _mediator.Send(new GetAllOrdersRequest());
            return this.FromResult(result);
        }

        //[Autorized]
        [HttpGet]
        [Route("customer/{customerId}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrdersByUser([FromRoute] Guid customerId)
        {
            var ordersResult = await _mediator.Send(new GetOrdersByCustomerReqest(customerId));
            return this.FromResult(ordersResult);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Order>> SubmitOrder([FromBody] OrderDto order)
        {
            var productResult = await _mediator.Send(new GetProductRequest(order.ProductId));
            return this.FromResult(new NotFoundErrorResult<Order>());
        }

        [HttpPut]
        public async Task<ActionResult<Order>> UpdateAddress([FromBody] OrderDto orderDto)
        {
            return NotFound();
        }
    }
}
