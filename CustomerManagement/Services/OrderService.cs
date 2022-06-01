using CustomerManagement.Controllers;
using CustomerManagement.Models;
using CustomerManagement.Repositories;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public void AddOrder(OrderViewModel order)
        {
            Order orderModel = new Order
            {
                NumberOfOrder = order.NumberOfOrder,
                PurchaseDate = order.PurchaseDate
            };
            
            foreach(var productId in order.ProductIds)
            {
                var productOrder = new ProductOrder
                {
                    OrderId = orderModel.Id,
                    ProductId = productId
                };
                orderModel.ProductOrders.Add(productOrder);
            }
            _repo.AddOrder(orderModel);
        }
    }
}
