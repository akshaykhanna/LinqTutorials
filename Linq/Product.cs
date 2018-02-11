using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int QuantityAvailable { get; set; }
        static int count = 1000;
        public Product()
        {
            this.ProductId = (count++);
        }
    }
}
