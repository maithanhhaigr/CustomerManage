using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CustomerManagement.Models;
using CustomerManagement.Services;
using CustomerManagement.Statics;
using CustomerManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Controllers
{
    [Authorize]
    //[Authorize(Roles = "InternalUser")]
    public class ProductController : Controller
    {
        //Dat de han che viec khoi tao
        private readonly IProductService _service;

        private readonly ICategoryService _categoryservice;

        public ProductController(IProductService service, ICategoryService categoryService)
        {
            _service = service;
            _categoryservice = categoryService;
        }

        [Authorize(Roles = "quantri")]
        public IActionResult Index()
        {
            var list = _service.GetAllProduct();
            return View(list);
        }

        [Authorize(Policy = Permissions.CreateCustomer)]
        public IActionResult Create()
        {
            ProductViewModel model = new ProductViewModel();
            model.CategorySelection = _categoryservice.GetCategorySelection();
            return View(model);
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

        [HttpGet]
        [Authorize]
        public Task<List<ProductViewModel>> Products(int numberOfQuantity)
        {
            var listProducts = _service.GetProducts(numberOfQuantity);
            return Task.FromResult(listProducts);
        }
    }
}