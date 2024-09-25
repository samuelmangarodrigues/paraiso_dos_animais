using System.ComponentModel.DataAnnotations;

namespace ParaisoDosAnimais.Models
{
    public class Cart :BaseModel
    {

        [MaxLength(255)] public required string ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public List<ProductCart> ProductCarts { get; init; } = [];
        public decimal TotalValue { get; private set; }

        public void CalculateTotalValue()
        {
            var value = ProductCarts.Sum(p => p.Product.Stock?.Price ?? 0M);
            TotalValue = value;
        }
    }
}