using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderWebGateway.Models;

namespace OrderWebGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderGatewayController : ControllerBase
    {
        private readonly ILogger<OrderGatewayController> logger;

        [HttpPost]
        public void Post(OrderModel orderModel)
        {

        }
    }
}