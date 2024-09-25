using System.ComponentModel.DataAnnotations;

namespace ParaisoDosAnimais.Models
{
    public class Address(string street, string neighborhood, int number, string zipCode) :BaseModel
    {
        [MaxLength(255)] public string ClientId { get; set; } = null!;
        public required Client Client { get; set; }
        [MaxLength(255)] public string Street { get; set; } = street;
        [MaxLength(50)] public string Neighborhood { get; set; } = neighborhood;
        public int Number { get; set; } = number;
        [MaxLength(50)] public string ZipCode { get; set; } = zipCode;
    }
}