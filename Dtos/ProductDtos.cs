namespace ParaisoDosAnimais.Dtos;
public record ProductDtos
{
    public ProductDtos(string name = "", string description = "", StockDtos? stock = null)
    {
        Name = name;
        Description = description;
        Stock = stock;
    }

    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public StockDtos? Stock { get; init; }

    
}
