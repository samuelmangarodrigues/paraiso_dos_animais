using System.ComponentModel.DataAnnotations;
using ParaisoDosAnimais.Services;

namespace ParaisoDosAnimais.Models
{
    public class Product(string name, string description) : BaseModel
    {
        
        [Required,MaxLength(255)] public string Name { get; set; } = name;
        [Required,MaxLength(255)] public string Description { get; set; } = description;
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public Stock? Stock { get; set; } 
        public List<ProductCart> ProductCarts { get; set; } = [];

    }
}
