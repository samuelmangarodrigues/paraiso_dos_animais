namespace ParaisoDosAnimais.Models
{
    public class Stock:BaseModel
    {
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
