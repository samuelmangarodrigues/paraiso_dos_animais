using Microsoft.CodeAnalysis;
using ParaisoDosAnimais.Dtos;
using ParaisoDosAnimais.Infrastructure.Context;
using ParaisoDosAnimais.Models;
using ParaisoDosAnimais.Services.Validations;

namespace ParaisoDosAnimais.Services
{
    public class ProductService(AppDbContext appDbContext)
    {
        private readonly AppDbContext _appDbContext = appDbContext;


        public void CreateProduct(Product product, Stock stock) {

            product.Stock= stock;

            if (stock != null) { 
                _appDbContext.Products.Add(product);
                _appDbContext.SaveChanges();
            }
        
        }

        public List<Product> GetAllProducts() => [.. _appDbContext.Products];

        public Product? GetProductById(Guid id) => _appDbContext.Products.Find(id);

        public bool UpdateProduct(Guid id, ProductDtos productDto)
        {
            var existingProduct = _appDbContext.Products.FirstOrDefault(p => p.Id == id);

            if (existingProduct == null)
                return false;

            var validations = new ProductValidations();
            validations.ValidateFieldsUpdate(existingProduct, productDto);

            _appDbContext.SaveChanges();

            return true;
        }

        public bool DeleteProduct(Guid id) 
        { 
            var existingProduct = _appDbContext.Products.FirstOrDefault(p => p.Id == id);

            if (existingProduct == null) 
                return false;

            _appDbContext.Products.Remove(existingProduct);
            _appDbContext.SaveChanges();

            return true;
        }
    }
}
