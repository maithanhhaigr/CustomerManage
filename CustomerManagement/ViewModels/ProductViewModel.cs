using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        [Display(Name="Category Name")]
        public Category Category { get; set; }

        public List<SelectListItem> CategorySelection { get; set; }
    }
}
