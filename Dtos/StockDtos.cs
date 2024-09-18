namespace ParaisoDosAnimais.Dtos;

public record StockDtos {

    public StockDtos(int? quantity = null, decimal? price = null)
    {
        Quantity = quantity;
        Price = price;
    }

    public int? Quantity { get; set; }
    public decimal? Price { get; set; }


};

