namespace ParaisoDosAnimais.Models
{
    public class Product(string name, string description):BaseModel
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public Stock? Stock { get; set; }

        public IEnumerable<ProductCart> ProductCarts { get; set; } = [];
        public List<Cart> Carts { get; set; } = [];

    }
}
