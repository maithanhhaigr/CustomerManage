using CustomerManagement.Models;
using CustomerManagement.Repositories;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public void AddProduct(ProductViewModel product)
        {
            Product productModel = new Product
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
            _repo.AddProduct(productModel);
        }

        public double CalcularTotalPrices(Product product)
        {
            return product.Quantity * product.Price;
        }

        public List<ProductViewModel> GetAllProduct()
        {
            var products = _repo.GetAllProduct();
            List<ProductViewModel> _view = new List<ProductViewModel>();
            foreach(var product in products)
            {
                _view.Add(new ProductViewModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    TotalPrice = product.Price * product.Quantity
                });
            }
            return _view;
        }

        public ProductViewModel GetProduct(Guid id)
        {
            var productModel = _repo.GetProduct(id);
            var productViewModule = new ProductViewModel
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Price = productModel.Price,
                Quantity = productModel.Quantity,
                TotalPrice = productModel.Price * productModel.Quantity
            };
            return productViewModule;
        }
    }
}
