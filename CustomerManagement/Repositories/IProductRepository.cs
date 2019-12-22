using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;

namespace CustomerManagement.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        List<Product> GetAllProduct();

        Product GetProduct(Guid id);
    }
}
