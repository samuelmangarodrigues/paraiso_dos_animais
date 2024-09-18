namespace ParaisoDosAnimais.Models
{
    public class ProductCart
    {
        public Guid? ProductId { get; init; }
        public Guid? CartId { get; init; }
        public Product? Product { get; set; }
        public Cart? Cart { get; set; }
    }
}
    