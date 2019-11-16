using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWebGateway.Models
{
    public class OrderModel
    {
        public string OrderId { get; set; }

        public Dictionary<string, object> ProductPayloads { get; set; } = new Dictionary<string, object>();

    }
}
