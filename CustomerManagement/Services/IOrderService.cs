using CustomerManagement.Controllers;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public interface IOrderService
    {
        void AddOrder(OrderViewModel order);
    }
}
