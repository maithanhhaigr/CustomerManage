using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using CustomerManagement.Services;
using CustomerManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Controllers
{
    //[Authorize(Roles = "InternalUser")]
    public class ProductController : Controller
    {
        //Dat de han che viec khoi tao
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var list = _service.GetAllProduct();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult SaveNew(ProductViewModel product)
        {
            _service.AddProduct(product);
            return Redirect("Index");
        }

        public IActionResult View(Guid id)
        {
            var product = _service.GetProduct(id);
            return View(product);
        }
    }
}