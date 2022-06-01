using AutoMapper;
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
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void AddProduct(ProductViewModel product)
        {
            //Product productModel = new Product
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Price = product.Price,
            //    Quantity = product.Quantity,
            //    CategoryId = product.CategoryId
            //};
            //_repo.AddProduct(productModel);

            _repo.AddProduct(_mapper.Map<Product>(product));

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
                TotalPrice = productModel.Price * productModel.Quantity,
                Category = productModel.Category,
                CategoryId = productModel.CategoryId,
                CategoryName = productModel.Category.Name
            };
            return productViewModule;
        }


        public List<ProductViewModel> GetProducts(int numberOfQuantity)
        {
            var products = _repo.GetProducts(numberOfQuantity);
            List<ProductViewModel> viewModels = new List<ProductViewModel>();
            foreach (var product in products)
            {
                viewModels.Add(new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    TotalPrice = product.Price * product.Quantity
                });
            }
            return viewModels;
        }

    }
}
