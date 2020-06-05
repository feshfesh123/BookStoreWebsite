using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string FrontImgUrl { get; set; }
        public string MidImgUrl { get; set; }
        public string BackImgUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
