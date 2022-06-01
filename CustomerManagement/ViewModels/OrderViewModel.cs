﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        [Display(Name="Serial")]
        public int NumberOfOrder { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Guid ProductId { get; set; }
        public List<SelectListItem> ProductSelection { get; set; }
        public List<Guid> ProductIds { get; set; }
    }
}
