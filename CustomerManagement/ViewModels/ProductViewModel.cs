using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.ViewModels
{
    
    public class ProductViewModel: BaseViewModel
    {

        [Display(Name = "Product Name")]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        [Display(Name = "Total")]
        public double TotalPrice { get; set; }
    }
}
