using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Services;
using CustomerManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerManagement.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        private readonly IProductService _productService;

        public OrderController(IOrderService service, IProductService productService)
        {
            _service = service;
            _productService = productService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            OrderViewModel orderView = new OrderViewModel();
            orderView.ProductSelection = _productService.GetAllProduct()
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();
            return View(orderView);
        }

        public IActionResult SaveNew(OrderViewModel order)
        {
            _service.AddOrder(order);
            return Redirect("Index");
        }


    }
}