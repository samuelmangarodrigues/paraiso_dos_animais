namespace ParaisoDosAnimais.Models
{
    public class Cart:BaseModel
    {
        public string? ClientId { get; set; }
        public Client? Client { get; set; }
        public IEnumerable<ProductCart> ProductCarts { get; set; } = [];
        public List<Product> Products { get; set; } = [];

    }
}
