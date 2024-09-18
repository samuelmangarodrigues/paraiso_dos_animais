namespace ParaisoDosAnimais.Models
{
    public class ProductCart:BaseModel
    {
        public string? ProductId { get; init; }
        public string? CartId { get; init; }
        public Product? Product { get; set; }
        public Cart? Cart { get; set; }
    }
}
    