using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Models
{
    public class Product: BaseModel
    {
        [StringLength(50)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}