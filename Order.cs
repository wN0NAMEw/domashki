using System;
using System.Collections.Generic;
using System.Linq;

namespace chetonovoe
{
    public class Order
    {
        public string Id { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public double TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public Customer Customer { get; set; }

        public double CalculateTotalAmount()
        {
            return Items.Sum(item => (double)(item.Product.Price * item.Quantity));
        }
    }
}