//using ParaisoDosAnimais.Dtos;
using ParaisoDosAnimais.Models;

namespace ParaisoDosAnimais.Services.Validations
{
    public static class ProductValidations
    {
        public static void ValidateFieldsUpdate(Product existingProduct, string productDto) {

            //if (!string.IsNullOrWhiteSpace(productDto.Name)) 
            //    existingProduct.Name = productDto.Name;

            //if (!string.IsNullOrWhiteSpace(productDto.Description))
            //    existingProduct.Description = productDto.Description;

            //if (productDto.Stock == null) return;
            
            //if (productDto.Stock.Quantity != null)
            //    existingProduct.Stock.Quantity = productDto.Stock.Quantity.Value;
            
            //if (productDto.Stock.Price != null)
            //    existingProduct.Stock.Price = productDto.Stock.Price.Value;
        }
    }
}
