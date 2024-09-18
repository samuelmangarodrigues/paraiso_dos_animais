using ParaisoDosAnimais.Dtos;
using ParaisoDosAnimais.Models;

namespace ParaisoDosAnimais.Services.Validations
{
    public class ProductValidations
    {
        public void ValidateFieldsUpdate(Product existingProduct, ProductDtos productDto) {

            if (!string.IsNullOrWhiteSpace(productDto.Name))
                existingProduct.Name = productDto.Name;

            if (!string.IsNullOrWhiteSpace(productDto.Description))
                existingProduct.Description = productDto.Description;

            if (productDto.Stock != null && existingProduct.Stock != null)
            {
                if (productDto.Stock.Quantity != null)
                    existingProduct.Stock.Quantity = productDto.Stock.Quantity.Value;
                if (productDto.Stock.Price != null)
                    existingProduct.Stock.Price = productDto.Stock.Price.Value;
            }
        }
    }
}
