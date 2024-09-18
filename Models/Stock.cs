namespace ParaisoDosAnimais.Models
{
    public class Stock:BaseModel
    {
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
