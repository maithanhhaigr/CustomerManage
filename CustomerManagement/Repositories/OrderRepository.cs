using CustomerManagement.Data;
using CustomerManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        public readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddOrder(Order orderModel)
        {
            //_context.Database.ExecuteSqlCommand("sp_getproduct",)

            using(var dbTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Orders.Add(orderModel);
                    _context.SaveChanges();
                    dbTransaction.Commit();
                }
                catch(Exception ex)
                {
                    dbTransaction.Rollback();
                }
            }
        }
    }
}
