using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data.Entity
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quanity { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
