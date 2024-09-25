namespace ParaisoDosAnimais.Models
{
    public class ProductCart : BaseModel
    {

        public  Guid ProductId { get; init; }
        public  Guid CartId { get; init; }
        public Product Product { get; init; } = null!;
        public  Cart Cart { get; init; } = null!;

    }
}