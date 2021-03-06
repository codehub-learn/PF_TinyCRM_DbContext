using System;
using System.Collections.Generic;
using System.Text;

namespace PF_TinyCRM.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderProduct> OrderProducts {get; set;}

    }
}
