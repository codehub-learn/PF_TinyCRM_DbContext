using System;
using System.Collections.Generic;
using System.Text;

namespace PF_TinyCRM.Options
{
    public class ProductOptions
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
