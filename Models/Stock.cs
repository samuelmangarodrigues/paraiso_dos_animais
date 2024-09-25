namespace ParaisoDosAnimais.Models
{
    public class Stock : BaseModel
    {
        public Guid ProductId { get; init; }
        public Product Product { get; init; } = null!;

        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
    }
}