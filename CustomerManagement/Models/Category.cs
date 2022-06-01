﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class Category: BaseModel
    {
        [StringLength(50)]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
