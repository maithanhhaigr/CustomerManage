using CustomerManagement.Models;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public interface IProductService
    {
        void AddProduct(ProductViewModel product);

        List<ProductViewModel> GetAllProduct();

        double CalcularTotalPrices(Product product);

        ProductViewModel GetProduct(Guid id);

        List<ProductViewModel> GetProducts(int numberOfQuantity);
    }
}
