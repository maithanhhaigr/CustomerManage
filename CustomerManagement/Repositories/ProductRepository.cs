using CustomerManagement.Data;
using CustomerManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        //public static List<Product> products = new List<Product>();
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            //products.Add(product);
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public List<Product> GetAllProduct()
        {
            //products.Add(new Product() { Name = "Car", Price = 20000, Quantity = 5 });
            //products.Add(new Product() { Name = "Byte", Price = 10000, Quantity = 10 });
            //return products;
            return _context.Products.ToList();

        }

        public Product GetProduct(Guid id)
        {
            //return products.FirstOrDefault(a => a.Id == id);
            //return _context.Products.FirstOrDefault(a => a.Id == id);
            return _context.Products.Include(x => x.Category).FirstOrDefault(a => a.Id == id);
        }



        public List<Product> GetProducts(int numberOfQuantity)
        {
            try
            {
                return _context.Products.Where(x => x.Quantity >= numberOfQuantity).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
