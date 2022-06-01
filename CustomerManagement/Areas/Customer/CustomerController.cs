using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Areas.Customer
{
    [Area("Customer")]
    [Route("Customers/{controller=Home}/{action=Index}/{id?}")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}