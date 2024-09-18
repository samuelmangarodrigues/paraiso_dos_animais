namespace ParaisoDosAnimais.Models
{
    public class Address(string street,string neighborhood, int number,string zipCode) : BaseModel
    {
        public string? ClientId { get; set; }
        public Client? Client { get; set; }
        public string Street { get; set; } = street;
        public string Neighborhood { get; set;} = neighborhood;
        public int Number { get; set; } = number;
        public string ZipCode { get; set; } = zipCode;



    }
}
